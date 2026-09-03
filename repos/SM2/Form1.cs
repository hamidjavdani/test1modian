using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxCollectData.Library.Abstraction;

using TaxCollectData.Library.Business;
using TaxCollectData.Library.Dto.Config;
using TaxCollectData.Library.Dto.Content;

using TaxCollectData.Library.Enums;

using TaxCollectData.Library.Dto;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using TaxCollectData.Library.Dto.Properties;


namespace SM2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const string MEMORY_ID = "A3GAEA";

        //private const string PRIVATE_KEY = "MIIEvwIBADANBgkqhkiG9w0BAQEFAASCBKkwggSlAgEAAoIBAQDa7k1peSoKNIKpq+AtcysYfsUrHBgWrsp+AYcgurw8MCxD/Fl5q33g4AQ8xCpze5J2rl//SK5J3qa1kHID6zo3H1ICLeCyovsGt4AEPgdtD1nrA+RVV0ncZucHEXdHU9/NkDyNVNxJ5nfq1xULYxby5BiWFjz8KoR0TGyEKP3YgudFe4ZkbBRapmUOmBANuOcR9TeK6K7UlsoRKhrRGvNmqoXPRfxgdrmpPRFtAxhGbjpp7nMQ4pcaudWlvkzUbkLi7ZEfSfwJoRWECcsuSp1iFeCBj6MOn4oKIAkT7N0nuLoAhOT1Ufad2eyEkd2NdY67AaWmCYz8MrZN7CJB6Y7XAgMBAAECggEBAKosAzYRvTCzgkDaXWVWmM/wcdfBfaPb93+cNmmlXH04QKATvYTKXQz3c7O8EvcyvTTM88ddukOm8lQ807LiG50PFlKlUHvqHU8qQTKK+IC4Jv97Rfdj4wCTZ85hsCJcOqDxFXAR3yz+HIYI6s2wFv1zePzoijzD27L+WHcd2bp5DW5eWpAOwvNuEo97Z43hjMrNU1LDW5VTbk0lpwUt5wAV6xaGPQipmX7QdqiWN/Or6eGpDe/PAMPO1Dd8JTOX9vSdnH13D15IgS3mqbtFPqPeAMXW8l5xPUZctsJ9DhidUMZDeShA4PNgO9TJkgTH9lxtIzCVF5PHfJR0Ape0OgkCgYEA9opmv9cD2kYXkYLZTjRynEAbO4uwlohjD/X97QHA+m6NWXjN6Yx0nHhkFJXXOzPlGfgZl5FoCBHVw8nxxo3UMK2N4a+OobHzgc0tLqXOW//eloQWD5z8jBKuIr1GjRwaJ6IsIm03/50eTnNbMmHqcmlHw3VNEKdE5G90LQ2GogUCgYEA41S1mXedgumrvNaWw8WjxZLtd6B8i2BamwLN9iTrcUhqY08CedMdllOWq3lBwvsgvvay7DpwlybYLfL5bun2XssCBBRJWNaSEMZgQ6dkT0nW5fHgrSwOgeGBBUi0fdGPBCBIEX9aG7o0hy5t6Lb0JrmVgF3u+avjeHy3VUwSeCsCgYEAlil0LdKbkR3yCvnku6JsUEknjRwnIXjOxZDx6aKQ1LfzNhTDbkXTXN5jLrqZToDsQOYBSHUTJR8f0VG2BlaqcD+1VEnmmQvXIi9DHs90okp1W7315eqbVAGouJYKW7ZLI+q98PYPDoy3Qdc3K7fB4Y/IWv+eQc9vwac03qAHabUCgYEA4DSflmh+lKrZkjkiIJtAVo/+XMmPi/bP5anycB0hiGyfYKqACp7Iw4ZVR3EkBqWfOjgdZxaMDMdm1oqYr2dYcU1PA67uWAvnq1u7fX4OVJTCua7ApIqbFEXP9eIrARw5LRyZd4he2pHfVKPaCnbGfZrzc9Mw6lU415BJUHrijFkCgYA9vxudUU1PSqSr4uFFcVawqSUExlKprndMLOAxzeAwHQhDbOtEqoONitDJiW7VxApS32uj+ihEzcHpYuhsMOs+qKqgSySYuPoPzdQGFFlQVsBLvpDKmYdnObWeehBVtXTbwgkl0qFx8BLeSqi344uCPM4n8DKPnGouHrP/drlmIw==";
        //private const string MEMORY_ID = "A36H5M";
        private const string PRIVATE_KEY = "MIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCs+d1LN+PxQpwO0fKoM2psrDNgqc+sRaldgMTQbvhdEaLr8Tmz+NycNEU0Rx6JT7RFLWWmRe+ELG1xCAMK5vRrcRlVipFA4l3yEjiSpLOsWsVVuWcn8RyPXvxKXbNx/FCZiGIfyDG5xa/iurLAOf7wKJpSnivboWq9xEZ/UsQtiUKzfb3vPEbNzNECmRpnVMsilX7ts0TsV6wX7VkMoXHwTKulQe4YonlmgMAI9dYJ5qHsWEY6YUBFvySzWUETDVbQcyVOWF3TlFTNGvWgVu/dZZ339kBulZ1Yz8TJnJr6OZdgUiOSJQvZfsfhoYWpmd9j5ELU+QTAEUDfuZU+LuA7AgMBAAECggEAAzVl/SAzR+VkFFj2oazFJkY8yb08pJsXh4F8+nTPLJgdfTeYn2sCr0RqSDb4LQnfySy3ZvyDHeDebYCoNcqPnB1D9V9ATy4jxKVr4TnRj2U7pdnDkm0ZijCeiMPw29tspKcaqDDuzd20joXHYmNxBC7B9hMIXebs85+Gwz6GHxDAlcRk027lzdNiVPv3mWszEmpNyKW9+vtnXbZO7kgBerfAuUNdFd7P8MogVFZ1Csw+p0SeS01TWbErkIY7N6Z3WETumcGTn7bFr3Qesv2rqXqF/QETJhl1EVw0GBQ6k2ODOiusT19AbkN8ZINKcw8Evn7/zf2vNyOV1K8p6XgewQKBgQDhTmlFQdRQ08n7NE/c0vC66tcK3De1tj4OMbK6Pjrb2W7LIbjIP46k2lQuJfvWps6MyqCIIy2XUl2FHE01OpFuueYQC7t34QdkQPW49P9jtWFffobAGhG2SWrGFIUvlxDrW9OI/Qr2oNlMxO4brwPJQeVHamIsxvc/O3JQe26JYQKBgQDEim2QXpDDopQ+z0apLVE30YgUrxlveKJIYLeSZeTqu2yhVdITsD7mQBGpBfp6qln4dFmQMzgnye1TtCaQZew4GHVQf/7zSx9+AyqcHFkGQ35sww51w6VroEoVvfAu486fcwCAz7yODuXr/ERxsmXVg/i925Hi9eoj1wfB2tJDGwKBgGWM9Q/dSvgfbYOHIZPzk8N8A+8GMSn6+V9mcRtW3yqmhzSRf3rqgr21FooyXp9yUdjNn6ucx3jUDAjqJ7adLl3M9nA3CYlP6Qf764UxEEd9wmTLX6sIVQFnd/PN3fYETgD3Q5IUE7Pz7d2XSYc6zCcTR2d4AMYT6+8ZOT4jVEAhAoGAKB3dSUeUIuqPedaTJLsERfF15krrVS55aW6cabx0olkJTlEXJT+nRxYyxJ5cxyb4YFdXZLCfuLdlwt0Vtgmn0rdjUsAdiQl/bxg0XVMH9NhX+NlDnVQG8tXv6UowuVF0fmVZ5/D/Grv9wFJoohB46sEaR56Gw53QYeplQfNpUZsCgYEAgIED7Iy8f4B11SgFfs3kej6+/1vTBQT0ePZzW9Z5DeWsW/OeItZ/NJnDmvnhgDzUtmROBkUEQdOvU1MfdzXIIqVPlaFj1XMT4/HcLtV1pqBFtRN4FHhDbAh+FunNmQbR2o3kBf3mPZCNrGwPFbrb/R/VCcKO1qHleQokdRbUd4c=";

        private ITaxApis _api;
     
        private void Form1_Load(object sender, EventArgs e)
        {
       
            TaxApiService.Instance.Init(MEMORY_ID,
                new SignatoryConfig(PRIVATE_KEY, null)
                ,new NormalProperties(ClientType.SELF_TSP), "https://tp.tax.gov.ir/req/api/");

            _api = TaxApiService.Instance.TaxApis;
            var serverInformation = _api.GetServerInformation();
            var token = _api.RequestToken();
            var economicCodeInformation = _api.GetEconomicCodeInformation("14002861227");
            var fiscalInformation = _api.GetFiscalInformation(MEMORY_ID);
            var uidAndFiscalId1 = new UidAndFiscalId("A3GAEA04F6D000000000B8", MEMORY_ID);
            var inquiryResultModels1 =
               TaxApiService.Instance.TaxApis.InquiryByUidAndFiscalId(new(){uidAndFiscalId1
               });
            var inquiryResultModels2 =
         TaxApiService.Instance.TaxApis.InquiryByTime("14040730");

            using (var context = new Models.MunicipalityDbContext())
            {
                var products = context.ViewPardakhtMns.Where(p =>p.State==null && string.Compare(p.Datepardakht.ToLower(), "1404/07/12".ToLower()) >= 0
             && string.Compare(p.Datepardakht.ToLower(), "1404/07/12".ToLower()) <= 0).ToList(); // Fetch all products
                foreach (var product in products)
                {

                    string taxId =
TaxApiService.Instance.TaxIdGenerator.GenerateTaxId(MEMORY_ID, 10002,
DateTime.Now);

                   
                    var random = new Random();

                    long randomSerialDecimal = random.Next(999999999);
                    var now = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds();
                    var header = new InvoiceHeaderDto
                    {
                        Ins = 1,//موضوع صورتحساب
                        Inty = 1,// نوع صورتحساب
                        Inp = 5,
                        Inno = string.Format("{0:X}", 1).PadLeft(10, '0'),
                        Tins = "14002861227",
                        //Bid="",//شماره/شناسه ملی/شناسه مشارکت مدنی/کد فراگیر خریدار
                        //Tinb="",// شماره اقتصادی خریدار
                        Tob = 1,//نوع شخص خریدار
                        Billid = product.Shenasehghabz,// شماره اشتراک/ شناسه قبض بهره بردار
                        Tprdis = product.Pardakhti,
                        Tdis = 0,//تخفیف
                        Tvam = product.Pardakhti *(decimal) 0.1,//ارزش افروده
                        Todam = 0,//سایر عوارض
                        Tadis = product.Pardakhti,//مجموع مبلغ پس از کسر تخفیف
                        Tbill = product.Pardakhti+(product.Pardakhti * (decimal)0.1),
                        Setm = 1,//روش تسویه
                        Cap = product.Pardakhti + (product.Pardakhti * (decimal)0.1),//مبلغ نقدی
                        Insp = 0,//مبلع نسیه
                        Tvop = 0,//مجموع سهم مالیات بر ارزش افزوده از پرداخت
                        Tax17 = 0,
                        Indatim = now,//تاریخ و زمان صدور صورتحساب)(
                        Indati2m = now,//تاریخ و زمان ایجاد صورتحساب)( 
                        Taxid = taxId
                    };
                    var header1 = new InvoiceHeaderDto
                    {
                        Ins =1,
                        Inty = 1,
                        Inp = 1,
                        Inno = string.Format("{0:X}", randomSerialDecimal).PadLeft(10, '0'),
                        Tins = "14002861227",
                        Tprdis = 1000,
                        Tdis = 0,
                        Tvam = 0,
                        Todam = 0,
                        Tbill = 1000,
                        Setm = 1,
                        Cap = 1000,
                        Insp = 1000,
                        Tvop = 0,
                        Tax17 = 0,
                        Indatim = now,
                        Indati2m = now,
                        Taxid = taxId
                    };
                    var body = new InvoiceBodyDto
                    {
                        Sstid = "2330001031184",//شناسه کال/خدمت

                        Sstt = product.Onvanitem,
                        Mu = "1627",// واحد اندازه گیری
                        Am = 1,//تعداد
                        Fee = product.Pardakhti ,
                        Prdis = product.Pardakhti ,//مبلغ قبل از تخفیف 
                        Dis = 0,//مبلغ تخفیف 
                        Adis = product.Pardakhti,// مبلغ بعد از تخفیف 
                        Vra = 10,//نرخ مالیات بر ارزش افزوده
                        Vam = product.Pardakhti ,//مبلغ مالیات بر ارزش افزوده 
                        Tsstam = product.Pardakhti + (product.Pardakhti * (decimal)0.1)//مبلغ کل کال/خدمت 
                    };
                
                var body1 = new InvoiceBodyDto
                {
                    Sstid = "2330001031184",//شناسه کال/خدمت
                    Sstt = product.Onvanitem,
                    Mu = "1627",// واحد اندازه گیری
                    Am = 1,//تعداد
                    Fee = product.Pardakhti,
                    Prdis = product.Pardakhti,//مبلغ قبل از تخفیف 
                    Dis = 0,//مبلغ تخفیف 
                    Adis = product.Pardakhti,// مبلغ بعد از تخفیف 
                    Vra = 10,//نرخ مالیات بر ارزش افزوده
                    Vam = product.Pardakhti,//مبلغ مالیات بر ارزش افزوده 
                    Tsstam = product.Pardakhti + (product.Pardakhti * (decimal)0.1)//مبلغ کل کال/خدمت 
                };
                var payment = new PaymentDto
                    {
                        //Iinn = "1131244211",//شماره سوییچ پرداخت 
                        //Acn = "2131244212",//شماره پذیرنده فروشگاهی
                        //Trmn = "3131244213",// پایانه ش
                        Trn = "4131244214"//شماره پیگیری
                    };
               
                var payment1 = new PaymentDto
                {
                    //Iinn = "1131244211",
                    //Acn = "2131244212",
                    //Trmn = "3131244213",
                    Trn = "4131244214"
                };
                var invoices = new List<InvoiceDto>
{
 new()
 {
 Body = new() {body1},
 Header = header1

 }
};
                    _api.GetServerInformation();
                   _api.RequestToken();
                    var responseModel = _api.SendInvoices(invoices,
                    null);
                    
                    var packetResponse = responseModel.Body.Result.First();
                    var uid = packetResponse.Uid;
                    var referenceNumber = packetResponse.ReferenceNumber;
                    var pardakhti = context.Tblpardakhts.Find(product.Idrow);
                   
                    
                        //var sql = "UPDATE Tblpardakht SET Stat =1,Shomarepeygiri={0} WHERE idrow={1};";
                        //context.Database.ExecuteSql(sql);
                    
                    if (pardakhti!=null)
                    {
                        pardakhti.State = 1;
                        pardakhti.Shomarepeygiri = uid.ToString();
                       int res= context.SaveChanges();
                    }
                    
                    var uidAndFiscalId = new UidAndFiscalId(uid, MEMORY_ID);
                    var inquiryResultModels =
                   TaxApiService.Instance.TaxApis.InquiryByUidAndFiscalId(new(){uidAndFiscalId
                   });
                }
            }








           



            //         var token= _api.RequestToken();
            //          string taxId =
            //TaxApiService.Instance.TaxIdGenerator.GenerateTaxId("A36H5M", 10001,
            //  DateTime.Now);
            //           var inquiryResultModels =_api.InquiryByTimeRange("14030101", "14031219");

            //          var uidAndFiscalId = new UidAndFiscalId("A36H5M04E7300000000039	", MEMORY_ID);
            //          List<UidAndFiscalId> list = new List<UidAndFiscalId>();
            //          list.Add(uidAndFiscalId);
            //          var inquiryResultModels1 =_api.InquiryByUidAndFiscalId(list);
            //          var economicCodeInformation = _api.GetEconomicCodeInformation("14004555270");

        }
    }
}
