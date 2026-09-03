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
using TaxCollectData.Library.Dto.Properties;
using TaxCollectData.Library.Enums;

namespace SM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string MEMORY_ID = "A36H5M";

        private const string PRIVATE_KEY = "MIIEvwIBADANBgkqhkiG9w0BAQEFAASCBKkwggSlAgEAAoIBAQDa7k1peSoKNIKpq+AtcysYfsUrHBgWrsp+AYcgurw8MCxD/Fl5q33g4AQ8xCpze5J2rl//SK5J3qa1kHID6zo3H1ICLeCyovsGt4AEPgdtD1nrA+RVV0ncZucHEXdHU9/NkDyNVNxJ5nfq1xULYxby5BiWFjz8KoR0TGyEKP3YgudFe4ZkbBRapmUOmBANuOcR9TeK6K7UlsoRKhrRGvNmqoXPRfxgdrmpPRFtAxhGbjpp7nMQ4pcaudWlvkzUbkLi7ZEfSfwJoRWECcsuSp1iFeCBj6MOn4oKIAkT7N0nuLoAhOT1Ufad2eyEkd2NdY67AaWmCYz8MrZN7CJB6Y7XAgMBAAECggEBAKosAzYRvTCzgkDaXWVWmM/wcdfBfaPb93+cNmmlXH04QKATvYTKXQz3c7O8EvcyvTTM88ddukOm8lQ807LiG50PFlKlUHvqHU8qQTKK+IC4Jv97Rfdj4wCTZ85hsCJcOqDxFXAR3yz+HIYI6s2wFv1zePzoijzD27L+WHcd2bp5DW5eWpAOwvNuEo97Z43hjMrNU1LDW5VTbk0lpwUt5wAV6xaGPQipmX7QdqiWN/Or6eGpDe/PAMPO1Dd8JTOX9vSdnH13D15IgS3mqbtFPqPeAMXW8l5xPUZctsJ9DhidUMZDeShA4PNgO9TJkgTH9lxtIzCVF5PHfJR0Ape0OgkCgYEA9opmv9cD2kYXkYLZTjRynEAbO4uwlohjD/X97QHA+m6NWXjN6Yx0nHhkFJXXOzPlGfgZl5FoCBHVw8nxxo3UMK2N4a+OobHzgc0tLqXOW//eloQWD5z8jBKuIr1GjRwaJ6IsIm03/50eTnNbMmHqcmlHw3VNEKdE5G90LQ2GogUCgYEA41S1mXedgumrvNaWw8WjxZLtd6B8i2BamwLN9iTrcUhqY08CedMdllOWq3lBwvsgvvay7DpwlybYLfL5bun2XssCBBRJWNaSEMZgQ6dkT0nW5fHgrSwOgeGBBUi0fdGPBCBIEX9aG7o0hy5t6Lb0JrmVgF3u+avjeHy3VUwSeCsCgYEAlil0LdKbkR3yCvnku6JsUEknjRwnIXjOxZDx6aKQ1LfzNhTDbkXTXN5jLrqZToDsQOYBSHUTJR8f0VG2BlaqcD+1VEnmmQvXIi9DHs90okp1W7315eqbVAGouJYKW7ZLI+q98PYPDoy3Qdc3K7fB4Y/IWv+eQc9vwac03qAHabUCgYEA4DSflmh+lKrZkjkiIJtAVo/+XMmPi/bP5anycB0hiGyfYKqACp7Iw4ZVR3EkBqWfOjgdZxaMDMdm1oqYr2dYcU1PA67uWAvnq1u7fX4OVJTCua7ApIqbFEXP9eIrARw5LRyZd4he2pHfVKPaCnbGfZrzc9Mw6lU415BJUHrijFkCgYA9vxudUU1PSqSr4uFFcVawqSUExlKprndMLOAxzeAwHQhDbOtEqoONitDJiW7VxApS32uj+ihEzcHpYuhsMOs+qKqgSySYuPoPzdQGFFlQVsBLvpDKmYdnObWeehBVtXTbwgkl0qFx8BLeSqi344uCPM4n8DKPnGouHrP/drlmIw==";

        private ITaxApis _api;

        private void Form1_Load(object sender, EventArgs e)
        {

            TaxApiService.Instance.Init(MEMORY_ID,
                    new SignatoryConfig(PRIVATE_KEY, null),
                    new NormalProperties(ClientType.SELF_TSP), "https://tp.tax.gov.ir/req/api/");
            _api = TaxApiService.Instance.TaxApis;
            var serverInformation = _api.GetServerInformation();
            var token = _api.RequestToken();
            string taxId =
  TaxApiService.Instance.TaxIdGenerator.GenerateTaxId("A36H5M", 10001,
    DateTime.Now);
            var inquiryResultModels = _api.InquiryByTimeRange("14030101", "14031219");

            var uidAndFiscalId = new UidAndFiscalId("A36H5M04E7300000000039	", MEMORY_ID);
            List<UidAndFiscalId> list = new List<UidAndFiscalId>();
            list.Add(uidAndFiscalId);
            var inquiryResultModels1 = _api.InquiryByUidAndFiscalId(list);
            var economicCodeInformation = _api.GetEconomicCodeInformation("14004555270");
            var fiscalInformation = _api.GetFiscalInformation(MEMORY_ID);
        }
    }
}
