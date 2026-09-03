# PKB — Project Knowledge Base

## سامانه تحت وب اتصال شهرداری ساری به سامانه مودیان

> وضعیت سند: مرجع اصلی دانش پروژه و نقشه راه ساخت
>
> هدف: ثبت دانش کسب‌وکاری، تصمیمات فنی، قواعد صدور صورتحساب، جریان اتصال به API V2 سامانه مودیان، ساختار داده و مسیر توسعه نرم‌افزار جدید شهرداری ساری.
>
> اصل مهم: پروژه جدید از صفر طراحی و پیاده‌سازی می‌شود. کدهای قدیمی فقط برای استخراج دانش، داده، شناسه‌ها، تجربه اتصال موفق و شناخت ساختار دیتابیس استفاده می‌شوند و مبنای معماری نرم‌افزار جدید نیستند.

---

# 1. هدف پروژه

شهرداری ساری برای برخی خدمات خود مشمول صدور صورتحساب الکترونیکی و ارسال اطلاعات به سامانه مودیان است. هدف پروژه، ساخت یک نرم‌افزار تحت وب مستقل و قابل نگهداری است که بین سامانه درآمد شهرداری و سامانه مودیان قرار بگیرد.

نرم‌افزار جدید باید بتواند:

- صورتحساب الکترونیکی برای شرکت‌ها و دستگاه‌های اجرایی قبل از پرداخت صادر و ارسال کند.
- وصول‌های روزانه شهروندان را از سامانه درآمد شهرداری دریافت کند.
- بر اساس کد درآمدی، وضعیت مالیاتی هر درآمد را تشخیص دهد.
- برای وصول‌های مردمی صورتحساب نوع دوم تولید کند.
- صورتحساب را مطابق استانداردهای رسمی سامانه مودیان امضا و رمزگذاری کند.
- صورتحساب‌ها را به API V2 ارسال کند.
- UID و ReferenceNumber را ذخیره کند.
- وضعیت پردازش و وضعیت نهایی صورتحساب را استعلام کند.
- خطاهای برگشتی را ثبت و قابل پیگیری کند.
- از ارسال مجدد ناخواسته یا تولید TaxId تکراری جلوگیری کند.
- تاریخچه کامل هر صورتحساب را نگه دارد.

این نرم‌افزار جایگزین سامانه درآمد شهرداری نیست؛ نقش آن «پل اتصال سامانه درآمد شهرداری ساری به سامانه مودیان» است.

---

# 2. منابع دانشی پروژه

## 2.1 سند رسمی اصلی اتصال

سند مورد استفاده:

- عنوان: دستورالعمل فنی اتصال به سامانه مودیان
- شناسه سند: `RC_TICS.IS_v1.6`
- تاریخ: شهریور ۱۴۰۴
- API هدف: نسخه `V2`

این سند فرآیند فنی اتصال، احراز هویت، دریافت اطلاعات سرور، ارسال صورتحساب، استعلام، وضعیت کارپوشه و ثبت پرداخت را توضیح می‌دهد.

## 2.2 مستندات مکمل لازم

برای پیاده‌سازی کامل و Production باید همواره نسخه جاری این اسناد نیز کنترل شود:

1. دستورالعمل صدور صورتحساب الکترونیکی و الگوهای صورتحساب.
2. سند قالب شناسه یکتای حافظه مالیاتی و شماره منحصر به فرد مالیاتی (TaxId).
3. سند کدخطاهای سامانه مودیان.
4. فهرست معتبر شناسه کالا/خدمت عمومی و اختصاصی.
5. آخرین مقررات و تغییرات نرخ مالیات بر ارزش افزوده.

قاعده پروژه: هرجا بین کد قدیمی و سند رسمی اختلاف وجود داشته باشد، سند رسمی جاری مرجع است.

---

# 3. شناخت کسب‌وکار شهرداری ساری

شهرداری ارائه‌دهنده خدمت است و دریافت‌کننده خدمت می‌تواند یکی از این گروه‌ها باشد:

- شهروند
- شرکت خصوصی
- شرکت دولتی
- اداره یا دستگاه اجرایی
- سایر اشخاص حقوقی

برخی درآمدهای شهرداری مشمول ارزش افزوده‌اند، برخی معاف هستند و برخی اساساً جزء مأخذ ارزش افزوده نیستند.

بنابراین صرف دریافت یک مبلغ به معنی اعمال یک نرخ ثابت مالیاتی نیست. تصمیم مالیاتی باید از روی ماهیت درآمد و کد درآمدی انجام شود.

---

# 4. دو سناریوی اصلی کسب‌وکاری

## سناریو A — صدور صورتحساب قبل از پرداخت برای شرکت‌ها و ادارات

نمونه واقعی: شرکت گاز.

### جریان کسب‌وکار

1. شهرداری خدمتی برای یک شرکت/اداره انجام می‌دهد.
2. مبلغ خدمت محاسبه می‌شود.
3. در صورت مشمول بودن، مالیات و عوارض ارزش افزوده محاسبه می‌شود.
4. شرکت اعلام می‌کند ابتدا صورتحساب باید در سامانه مودیان ثبت شود.
5. کاربر شهرداری فرم صدور صورتحساب را تکمیل می‌کند.
6. نرم‌افزار صورتحساب نوع ۱ می‌سازد.
7. صورتحساب به سامانه مودیان ارسال می‌شود.
8. TaxId / ReferenceNumber و نتیجه استعلام ثبت می‌شود.
9. شرکت صورتحساب را در سامانه مودیان مشاهده می‌کند.
10. پس از آن پرداخت انجام می‌شود.

### نکته مهم

در این سناریو هنوز رکورد وصول در `tblpardakht` وجود ندارد. بنابراین منبع اطلاعات صورتحساب، فرم صدور صورتحساب و اطلاعات مطالبه/خدمت است؛ نه جدول وصول.

### مدل اولیه صورتحساب

- `Inty = 1` : صورتحساب نوع اول
- `Inp = 1` : الگوی فروش کالا/خدمت (تا زمانی که سند جاری برای خدمت خاص الگوی دیگری تعیین نکرده باشد)
- `Ins = 1` : صورتحساب اصلی
- اطلاعات فروشنده: شهرداری ساری
- اطلاعات خریدار: شناسه اقتصادی/ملی شرکت یا اداره
- روش تسویه: بر اساس واقعیت معامله؛ در سناریوی قبل از پرداخت معمولاً نسیه یا نقدی/نسیه

### بعد از پرداخت

در صورتی که صورتحساب با روش نسیه یا نقدی/نسیه صادر شده باشد، API V2 سرویس ثبت پرداخت صورتحساب را نیز فراهم می‌کند. این موضوع با «ارسال تجمیعی درآمد روزانه» متفاوت است.

---

## سناریو B — وصول‌های روزانه شهروندان

این سناریو مربوط به مبالغی است که قبلاً توسط شهروند پرداخت و در سامانه درآمد شهرداری ثبت شده‌اند.

### منبع اصلی داده

جدول موجود شهرداری:

`tblpardakht`

فیلدهای شناخته‌شده و مهم:

- `idrow`
- `codeitem`
- `pardakhti`
- `datepardakht`
- `shenasehghabz`
- `shenasehpardakht`
- `malek`
- `codemeli`
- `codeparvandeh`
- `shomarepeygiri`
- `state`

همچنین View موجود در نمونه قدیمی:

`ViewPardakhtMn`

شامل مواردی نظیر:

- Idrow
- Malek
- Codemeli
- Codeitem
- Onvanitem
- Pardakhti
- Datepardakht
- Shenasehghabz
- Shomarepeygiri
- State

### جریان کسب‌وکار

1. شهروند پرداخت را انجام می‌دهد.
2. رکورد وصول در `tblpardakht` ثبت می‌شود.
3. برنامه جدید وصول‌های ارسال‌نشده را انتخاب می‌کند.
4. از روی `CodeItem` ماهیت درآمد را تشخیص می‌دهد.
5. جدول قواعد مالیاتی تعیین می‌کند درآمد:
   - مشمول است
   - معاف است
   - جزء مأخذ نیست
6. SSTID مناسب انتخاب می‌شود.
7. صورتحساب نوع ۲ ساخته می‌شود.
8. صورتحساب‌ها به‌صورت روزانه ارسال می‌شوند.
9. چند صورتحساب مستقل می‌توانند در یک Batch API ارسال شوند.
10. نتیجه ارسال و استعلام برای هر صورتحساب جداگانه ذخیره می‌شود.

### مدل اولیه صورتحساب

- `Inty = 2` : صورتحساب نوع دوم
- `Inp = 1` : فروش کالا/خدمت، تا زمانی که دستورالعمل جاری مورد خاص دیگری را الزام نکند
- `Ins = 1` : صورتحساب اصلی
- اطلاعات خریدار برای مصرف‌کننده نهایی الزام اصلی سناریو نیست
- `Setm = 1` : نقدی

### اصل مهم درباره «ارسال روزانه»

ارسال روزانه به معنی ساخت یک صورتحساب تجمیعی برای کل وصول روز نیست.

مدل فنی پیشنهادی:

- هر وصول/رویداد درآمدی → یک صورتحساب مستقل
- هر صورتحساب → TaxId و RequestTraceId مستقل
- چند صورتحساب مستقل → ارسال در یک Batch API

سند API V2 اجازه ارسال حداکثر ۱۰۰۰ صورتحساب مستقل در یک درخواست را می‌دهد.

---

# 5. جدول کدهای درآمدی و قواعد مالیاتی

شهرداری ساری دارای طبقه‌بندی درآمدی است. فایل بررسی‌شده نشان می‌دهد درآمدها از نظر ارزش افزوده یکسان نیستند.

نمونه‌های شناخته‌شده:

- `120110` — بهای خدمات مدیریت پسماند → مشمول
- `110401` — عوارض نوسازی → جزء مأخذ نمی‌باشد
- برخی خدمات حمل‌ونقل و خدمات شهری → مشمول
- برخی خدمات → معاف طبق ماده ۹

بنابراین در نرم‌افزار جدید نباید قواعد مالیاتی داخل کد Hard-code شوند.

### جدول تنظیمات پیشنهادی

`MoadianRevenueRule`

فیلدهای پیشنهادی:

- `Id`
- `CodeItem`
- `RevenueTitle`
- `TaxTreatment`
  - Taxable
  - Exempt
  - OutOfScope
- `VatRate`
- `Sstid`
- `SstidTitle`
- `UnitCode`
- `IsActive`
- `EffectiveFrom`
- `EffectiveTo`
- `Notes`

قاعده اصلی:

`CodeItem → TaxTreatment → SSTID → VAT Rate`

---

# 6. شناسه کالا/خدمت SSTID

در نمونه اجرایی قبلی شهرداری برای ارسال آزمایشی/واقعی از شناسه:

`2330001031184`

استفاده شده است.

در کد نمونه، همین مقدار در `Sstid` قرار می‌گرفت و عنوان واقعی خدمت از `Onvanitem` خوانده می‌شد.

این تجربه نشان می‌دهد می‌توان برای برخی خدمات از شناسه عمومی معتبر استفاده کرد.

اما در نرم‌افزار جدید:

- SSTID نباید در کد Hard-code شود.
- باید در جدول تنظیمات درآمد نگهداری شود.
- چند `CodeItem` می‌توانند در صورت انطباق قانونی به یک SSTID عمومی متصل شوند.
- SSTID باید در فهرست معتبر سامانه مودیان وجود داشته باشد.
- نرخ و وضعیت مالیاتی SSTID باید با ماهیت درآمد تطبیق داشته باشد.

---

# 7. تجربه سیستم قدیمی

## 7.1 پروژه مهم قدیمی

مسیر:

`repos/SM2`

فایل اصلی:

`repos/SM2/Form1.cs`

مشخصات:

- .NET 8 WinForms
- EF Core 8
- SQL Server
- پکیج `TaxCollectData.Library.Main`

## 7.2 موارد قابل استفاده به عنوان دانش

- شناسه حافظه مالیاتی استفاده‌شده: `A3GAEA`
- شناسه اقتصادی استفاده‌شده برای شهرداری: `14002861227`
- SSTID نمونه: `2330001031184`
- ساختار جداول وصول
- تجربه واقعی برقراری اتصال
- تجربه واقعی ارسال حداقل یک صورتحساب که در سامانه مودیان مشاهده شده است

## 7.3 مواردی که نباید از کد قدیمی تقلید شوند

- معماری WinForms
- Hard-code کردن کلیدها
- Hard-code کردن نرخ VAT
- Hard-code کردن SSTID
- استفاده از `State` به‌تنهایی برای وضعیت کامل مودیان
- ذخیره UID به جای تفکیک UID و ReferenceNumber
- Random ساده برای سریال صورتحساب
- منطق ناقص یا آزمایشی Header/Body

## 7.4 ایراد شناخته‌شده در نمونه قدیمی

در Body قدیمی:

- `Vra = 10`
- ولی `Vam = product.Pardakhti`

این با فرمول صحیح VAT سازگار نیست.

اگر:

- مبلغ پس از تخفیف = 1,000,000
- نرخ VAT = 10%

آنگاه:

- `Vam = 100,000`
- `Tsstam = 1,100,000`

نرم‌افزار جدید باید تمام جمع‌ها را به‌صورت محاسباتی و قابل تست تولید کند.

---

# 8. اطلاعات پایه اتصال

## موجود یا شناخته‌شده

- Fiscal Memory ID قدیمی: `A3GAEA`
- شناسه اقتصادی شهرداری: `14002861227`
- Private Key قبلی در کد قدیمی موجود بوده است
- اتصال قبلی حداقل یک ارسال موفق واقعی داشته است
- Endpoint قبلی API قدیمی شناخته شده است
- Endpoint جدید API V2 از سند رسمی مشخص است

## مورد حیاتی نیازمند تأیید

### Certificate شهرداری

API V2 از گواهی امضا در فرآیند احراز هویت و امضای صورتحساب استفاده می‌کند.

باید فایل/گواهی متناظر با Private Key شهرداری پیدا و اعتبار آن بررسی شود.

فرمت‌های محتمل:

- `.crt`
- `.cer`
- `.pfx`
- `.pem`

همچنین باید کنترل شود:

- Certificate منقضی نشده باشد.
- شناسه ملی موجود در Certificate با شهرداری سازگار باشد.
- Certificate/Public Key در کارپوشه برای FiscalId مربوط معرفی شده باشد.
- حالت ارسال اطلاعات در کارپوشه صحیح باشد.

### سیاست امنیتی

Private Key، Certificate Password و سایر Secrets نباید در Git Repository قرار گیرند.

در نرم‌افزار جدید Secrets باید از یکی از روش‌های امن مانند Secret Store / Environment Variable / Protected Configuration دریافت شوند.

---

# 9. معماری مفهومی سیستم

```text
سامانه درآمد شهرداری / فرم صدور صورتحساب
                │
                ▼
       لایه تشخیص سناریو
        نوع ۱        نوع ۲
                │
                ▼
        Revenue Rule Engine
CodeItem → TaxTreatment → SSTID → VAT
                │
                ▼
          Invoice Builder
       Header + Body + Payments
                │
                ▼
          TaxId Generator
                │
                ▼
       Moadian V2 Auth Client
      Nonce → JWT/JWS Token
                │
                ▼
       Server Information
        PublicKey + KeyId
                │
                ▼
         Invoice Signing
               JWS
                │
                ▼
       Invoice Encryption
               JWE
                │
                ▼
       POST /api/v2/invoice
                │
                ▼
       UID + ReferenceNumber
                │
                ▼
           Inquiry Engine
                │
                ▼
       Final Status + Errors
                │
                ▼
         Moadian Database
```

---

# 10. جریان رسمی API V2

## 10.1 دریافت Nonce

Endpoint:

`GET /requestsmanager/api/v2/nonce`

Nonce:

- یکبارمصرف است.
- زمان اعتبار محدود دارد.
- TTL پیش‌فرض در سند ۳۰ ثانیه است.
- برای تولید توکن احراز هویت استفاده می‌شود.

## 10.2 ساخت توکن احراز هویت

Payload اصلی:

- `nonce`
- `clientId`

برای مودی، `clientId` همان Fiscal Memory ID است.

توکن با استاندارد JWS و الگوریتم RS256 امضا می‌شود.

گواهی امضا در Header قرار می‌گیرد.

اصل مهم سند V2:

هر درخواست نیازمند فرآیند احراز هویت مربوط به خودش است و Token یک‌بارمصرف است.

## 10.3 دریافت اطلاعات سرور

Endpoint:

`GET /requestsmanager/api/v2/server-information`

اطلاعات مهم خروجی:

- `serverTime`
- `publicKeys`
  - Key
  - Id
  - Algorithm
  - Purpose

کلید عمومی برای رمزگذاری JWE استفاده می‌شود.

## 10.4 تولید TaxId

TaxId باید برای هر صورتحساب یکتا باشد.

تولید آن باید مطابق سند رسمی TaxId انجام شود.

TaxId شامل اجزای مرتبط با:

- FiscalId
- تاریخ صدور
- سریال صورتحساب
- رقم کنترل

است.

### اصل طراحی

سریال TaxId نباید با `Random()` ساده تولید شود.

باید در دیتابیس یک سازوکار Sequencing تراکنشی و غیرتکراری وجود داشته باشد.

## 10.5 ساخت JSON صورتحساب

ساختار رسمی:

```text
Invoice
 ├── header
 ├── body[]
 └── payments[]
```

## 10.6 امضای صورتحساب — JWS

صورتحساب JSON با Private Key شهرداری امضا می‌شود.

JWS Header شامل اطلاعاتی مانند:

- `alg = RS256`
- `x5c`
- `sigT`
- `crit`

است.

## 10.7 رمزگذاری صورتحساب — JWE

صورتحساب امضاشده با کلید عمومی سازمان مالیاتی رمز می‌شود.

الگوریتم‌های اصلی سند:

- `RSA-OAEP-256`
- `A256GCM`

خروجی، Payload رمزشده JWE است.

## 10.8 ارسال صورتحساب

Endpoint:

`POST /requestsmanager/api/v2/invoice`

هر InvoicePacket شامل:

```text
header
 ├── requestTraceId
 └── fiscalId
payload = JWE
```

قواعد مهم:

- `requestTraceId` برای هر صورتحساب باید یکتا باشد.
- حداکثر ۱۰۰۰ صورتحساب در یک درخواست قابل ارسال است.
- Batch به معنی چند صورتحساب مستقل در یک درخواست است.

## 10.9 پاسخ ارسال

برای هر صورتحساب پاسخ شامل:

- `uid`
- `referenceNumber`

است.

دریافت ReferenceNumber به معنی پذیرش نهایی صورتحساب نیست.

## 10.10 استعلام پردازش

روش‌های استعلام موجود شامل:

- استعلام با ReferenceNumber
- استعلام با UID/FiscalId
- استعلام بازه زمانی

وضعیت‌هایی مانند:

- SUCCESS
- FAILED
- IN_PROGRESS
- NOT_FOUND

ممکن است مشاهده شوند.

## 10.11 وضعیت نهایی در کارپوشه

API وضعیت صورتحساب می‌تواند وضعیت‌هایی مانند موارد زیر برگرداند:

- APPROVED
- APPROVED_SYSTEMIC
- REJECTED
- REACTION_AWAITING
- REACTION_IMPOSSIBLE
- REACTION_NEED_NO
- CANCELED

نرم‌افزار باید بین «ارسال موفق به API» و «پذیرش نهایی صورتحساب» تفاوت قائل شود.

---

# 11. ساختار Header و Body مورد نیاز پروژه

## 11.1 Header — فیلدهای مهم

فیلدهای مهمی که در طراحی باید پشتیبانی شوند:

- `taxid`
- `inno`
- `indatim`
- `indati2m`
- `inty`
- `inp`
- `ins`
- `tins`
- `tob`
- `bid`
- `tinb`
- `tprdis`
- `tdis`
- `tadis`
- `tvam`
- `todam`
- `tbill`
- `setm`
- `cap`
- `insp`
- `tvop`
- سایر فیلدهای شرطی طبق الگوی صورتحساب جاری

## 11.2 Body — فیلدهای مهم

- `sstid` : شناسه کالا/خدمت
- `sstt` : شرح کالا/خدمت
- `mu` : واحد اندازه‌گیری
- `am` : مقدار/تعداد
- `fee` : مبلغ واحد
- `prdis` : مبلغ قبل از تخفیف
- `dis` : تخفیف
- `adis` : مبلغ پس از تخفیف
- `vra` : نرخ VAT
- `vam` : مبلغ VAT
- `tsstam` : مبلغ کل کالا/خدمت

### فرمول پایه

```text
prdis = am × fee
adis  = prdis - dis
vam   = adis × vatRate
        ----------------
              100

tsstam = adis + vam + سایر مالیات/عوارض مربوط به ردیف
```

### جمع‌های Header

```text
tprdis = Σ body.prdis
tdis   = Σ body.dis
tadis  = Σ body.adis
tvam   = Σ body.vam
tbill  = جمع نهایی صورتحساب
```

اصل مهم: Header باید از Body محاسبه شود، نه اینکه کاربر جمع‌های مستقل و ناسازگار وارد کند.

---

# 12. طراحی دیتابیس پیشنهادی

`tblpardakht` منبع وصول شهرداری باقی می‌ماند و نباید به جدول اصلی مدیریت مودیان تبدیل شود.

## 12.1 MoadianInvoice

جدول اصلی صورتحساب‌ها.

فیلدهای پیشنهادی:

- `Id`
- `SourceType`
  - ManualCompanyInvoice
  - MunicipalPayment
- `SourceId`
  - مثلاً `tblpardakht.idrow`
- `InvoiceType`
- `InvoicePattern`
- `InvoiceSubject`
- `TaxId`
- `InternalSerial`
- `FiscalId`
- `SellerEconomicCode`
- `BuyerType`
- `BuyerNationalId`
- `BuyerEconomicCode`
- `IssueDateTime`
- `SettlementMethod`
- `TotalBeforeDiscount`
- `TotalDiscount`
- `TotalAfterDiscount`
- `TotalVat`
- `TotalOtherTax`
- `TotalBill`
- `CurrentStatus`
- `CreatedAt`
- `UpdatedAt`

## 12.2 MoadianInvoiceItem

- `Id`
- `InvoiceId`
- `CodeItem`
- `Sstid`
- `Title`
- `UnitCode`
- `Quantity`
- `Fee`
- `PriceBeforeDiscount`
- `Discount`
- `PriceAfterDiscount`
- `VatRate`
- `VatAmount`
- `TotalAmount`

## 12.3 MoadianTransmission

هر تلاش ارسال جداگانه ثبت شود.

- `Id`
- `InvoiceId`
- `RequestTraceId`
- `ReferenceNumber`
- `Uid`
- `AttemptNo`
- `SentAt`
- `HttpStatus`
- `TransportStatus`
- `RawErrorCode`
- `ErrorMessage`
- `CreatedAt`

## 12.4 MoadianInquiry

- `Id`
- `InvoiceId`
- `TransmissionId`
- `InquiryType`
- `Status`
- `InvoiceStatus`
- `ErrorCode`
- `ErrorMessage`
- `RawResponse`
- `CheckedAt`

## 12.5 MoadianRevenueRule

جدول نگاشت CodeItem به قواعد مودیان که در بخش قبل توضیح داده شد.

## 12.6 MoadianSequence

برای تولید سریال غیرتکراری TaxId.

- `Id`
- `FiscalId`
- `LastSerial`
- `UpdatedAt`

استفاده از تراکنش/Sequence دیتابیس برای جلوگیری از تکرار ضروری است.

---

# 13. وضعیت‌های داخلی پیشنهادی

نرم‌افزار نباید فقط یک State صفر و یک داشته باشد.

وضعیت‌های داخلی پیشنهادی:

```text
Draft
ReadyToSend
ValidationFailed
Queued
Sending
Sent
Processing
Accepted
Rejected
Canceled
RetryRequired
Completed
```

این Status داخلی باید از Status رسمی API جدا باشد.

---

# 14. جلوگیری از ارسال تکراری

این موضوع برای وصول روزانه حیاتی است.

برای `SourceType = MunicipalPayment` باید حداقل یک Unique Constraint روی این منطق وجود داشته باشد:

```text
SourceType + SourceId + InvoiceSubjectVersion
```

در حالت ساده:

```text
MunicipalPayment + tblpardakht.idrow
```

نباید اجازه صدور دو صورتحساب اصلی برای یک وصول داده شود مگر در فرآیند رسمی اصلاحی/ابطالی/برگشت.

همچنین:

- TaxId یکتا
- RequestTraceId یکتا
- InternalSerial یکتا در محدوده FiscalId

باید در دیتابیس enforce شوند.

---

# 15. Batch روزانه وصول‌ها

نمونه جریان:

```text
انتخاب تاریخ
    ↓
خواندن tblpardakht
    ↓
حذف رکوردهایی که قبلاً صورتحساب دارند
    ↓
اعتبارسنجی CodeItem
    ↓
دریافت RevenueRule
    ↓
ساخت Invoice نوع ۲
    ↓
Validation
    ↓
تقسیم به Batchهای حداکثر 1000 تایی
    ↓
ارسال
    ↓
ثبت UID + ReferenceNumber
    ↓
Inquiry
    ↓
ثبت نتیجه نهایی
```

### اصل مهم

یک خطای یک صورتحساب نباید باعث گم شدن وضعیت ۹۹۹ صورتحساب دیگر شود.

پاسخ هر آیتم باید مستقل ذخیره شود.

---

# 16. رابط کاربری پیشنهادی

نرم‌افزار تحت وب حداقل این صفحات را نیاز دارد:

## 16.1 داشبورد

نمایش:

- تعداد صورتحساب امروز
- آماده ارسال
- ارسال‌شده
- در حال پردازش
- تأییدشده
- ردشده
- نیازمند بررسی

## 16.2 صدور صورتحساب شرکت/اداره

برای سناریوی نوع ۱.

اطلاعات:

- مشخصات خریدار
- شناسه ملی
- شماره اقتصادی
- نوع شخص
- کد درآمدی
- شرح خدمت
- مبلغ
- تخفیف
- SSTID
- نرخ مالیات
- روش تسویه
- پیش‌نمایش صورتحساب
- دکمه ارسال

## 16.3 وصول‌های روزانه

- انتخاب تاریخ
- نمایش وصول‌های `tblpardakht`
- CodeItem
- عنوان درآمد
- مبلغ وصول
- وضعیت مالیاتی
- SSTID
- VAT
- وضعیت ارسال مودیان
- امکان انتخاب چند رکورد
- ارسال Batch

## 16.4 پیگیری صورتحساب‌ها

فیلتر بر اساس:

- تاریخ
- TaxId
- ReferenceNumber
- CodeItem
- نوع صورتحساب
- وضعیت داخلی
- وضعیت مودیان

## 16.5 مدیریت قواعد درآمد

CRUD برای:

- CodeItem
- وضعیت مالیاتی
- SSTID
- نرخ VAT
- تاریخ اعتبار

## 16.6 تنظیمات اتصال

- FiscalId
- Seller Economic Code
- Environment
- Certificate metadata
- وضعیت اتصال

Secret واقعی در UI نمایش داده نشود.

---

# 17. معماری نرم‌افزار پیشنهادی

هدف: معماری تمیز اما غیرپیچیده.

پیشنهاد اولیه Solution:

```text
SariMoadian.sln

src/
  SariMoadian.Web
  SariMoadian.Application
  SariMoadian.Domain
  SariMoadian.Infrastructure

tests/
  SariMoadian.UnitTests
  SariMoadian.IntegrationTests
```

## Web

- Razor Pages یا ASP.NET Core MVC
- Authentication/Authorization
- UI
- Controllers/Pages

## Application

Use Caseها:

- CreateCompanyInvoice
- ImportDailyPayments
- BuildInvoice
- ValidateInvoice
- SendInvoiceBatch
- InquiryInvoice
- RegisterPayment

## Domain

مدل‌های مستقل:

- Invoice
- InvoiceItem
- RevenueRule
- TaxTreatment
- SettlementMethod
- InvoiceStatus

## Infrastructure

- EF Core
- SQL Server
- خواندن دیتابیس درآمد شهرداری
- Moadian V2 HTTP Client
- Cryptography
- Certificate Loader
- Secret Provider
- Logging

اصل: Logic کسب‌وکار نباید داخل Controller یا Page نوشته شود.

---

# 18. سرویس‌های فنی اصلی

این Interfaceها مسیر طبیعی توسعه هستند:

```text
IMoadianAuthenticationService
IMoadianServerInformationService
ITaxIdGenerator
IInvoiceBuilder
IInvoiceValidator
IInvoiceSigner
IInvoiceEncryptor
IMoadianInvoiceClient
IMoadianInquiryClient
IRevenueRuleService
IMunicipalPaymentReader
```

نام نهایی می‌تواند در زمان توسعه اصلاح شود؛ هدف ثبت مسئولیت‌هاست.

---

# 19. اعتبارسنجی قبل از ارسال

قبل از تماس با API باید Validation داخلی انجام شود.

موارد نمونه:

- CodeItem دارای RevenueRule باشد.
- SSTID خالی نباشد.
- Tax treatment مشخص باشد.
- VatRate معتبر باشد.
- جمع Header با Body برابر باشد.
- TaxId تکراری نباشد.
- RequestTraceId یکتا باشد.
- اطلاعات خریدار در Type 1 کامل باشد.
- Type 2 تسویه سازگار داشته باشد.
- مقادیر منفی غیرمجاز نباشند.
- IssueDate معتبر باشد.
- FiscalId تنظیم شده باشد.
- Certificate قابل بارگذاری باشد.

هدف: خطاهای قابل تشخیص را قبل از ارسال به مودیان پیدا کنیم.

---

# 20. Log و Audit

این پروژه مالی است و Audit باید جدی گرفته شود.

باید ثبت شود:

- چه کسی صورتحساب را ایجاد کرد.
- چه کسی ارسال کرد.
- چه زمانی ارسال شد.
- چه Payload منطقی‌ای ساخته شد.
- کدام RequestTraceId استفاده شد.
- ReferenceNumber چه بود.
- چه Statusهایی دریافت شد.
- چه خطایی رخ داد.
- چه Retryهایی انجام شد.

اما:

- Private Key
- Password
- JWT کامل
- Certificate Password

نباید در Log ذخیره شوند.

---

# 21. Retry Policy

Retry باید هوشمند باشد.

دو دسته خطا داریم:

## خطای فنی موقت

مثال:

- Timeout
- Network failure
- HTTP 5xx

ممکن است Retry مناسب باشد.

## خطای محتوایی

مثال:

- SSTID نامعتبر
- جمع مبلغ اشتباه
- اطلاعات خریدار نامعتبر

Retry خودکار بدون اصلاح داده فایده ندارد.

اصل مهم:

قبل از Retry ارسال، باید بررسی شود آیا درخواست قبلی ReferenceNumber گرفته است یا خیر تا Duplicate ایجاد نشود.

---

# 22. امنیت

قواعد قطعی:

- هیچ Private Key جدیدی در Git ثبت نشود.
- Private Key قدیمی موجود در Repository برای Production امن تلقی نشود.
- Secretها به Configuration امن منتقل شوند.
- Certificate expiration مانیتور شود.
- دسترسی صفحه تنظیمات محدود باشد.
- ارسال و مشاهده Logهای حساس Role-based باشد.
- HTTPS اجباری باشد.
- DB Credential در Source Code نباشد.

---

# 23. تست‌ها

## Unit Test

حداقل:

- محاسبه VAT
- محاسبه Header totals
- RevenueRule mapping
- Tax treatment
- TaxId serial logic
- Type 1 validation
- Type 2 validation

## Integration Test

- خواندن نمونه وصول از DB
- ساخت Invoice
- امضا با Certificate آزمایشی
- JWE encryption
- Mock پاسخ API
- ثبت Transmission
- ثبت Inquiry

## Live Test

فقط پس از آماده بودن Certificate معتبر و تنظیمات کارپوشه:

1. server-information
2. یک صورتحساب کنترل‌شده
3. دریافت ReferenceNumber
4. Inquiry
5. مشاهده در کارپوشه

سپس Batch کوچک و بعد Batch واقعی.

---

# 24. تصمیمات قطعی تا این مرحله

1. پروژه جدید تحت وب است.
2. پروژه از صفر طراحی می‌شود.
3. کد قدیمی فقط Reference است.
4. دو سناریوی اصلی داریم: Type 1 قبل از پرداخت و Type 2 برای وصول‌های روزانه.
5. `tblpardakht` منبع وصول است، نه دیتابیس اصلی مودیان.
6. وضعیت مودیان در جداول مستقل ذخیره می‌شود.
7. CodeItem مبنای نگاشت درآمد به قواعد مالیاتی است.
8. Tax/VAT Ruleها Hard-code نمی‌شوند.
9. SSTID Hard-code نمی‌شود.
10. امکان استفاده از شناسه عمومی معتبر SSTID وجود دارد و نمونه قدیمی از `2330001031184` استفاده کرده است.
11. هر وصول یک صورتحساب مستقل دارد؛ Batch صرفاً روش انتقال چند صورتحساب در یک Request است.
12. API هدف، V2 است.
13. Nonce/Token بر اساس قواعد V2 مدیریت می‌شود.
14. JWS و JWE طبق سند رسمی تولید می‌شوند.
15. ReferenceNumber پایان فرآیند نیست؛ Inquiry اجباری است.
16. TaxId و RequestTraceId باید یکتا باشند.
17. Secrets در Source Code ذخیره نمی‌شوند.
18. قبل از Production باید Certificate معتبر شهرداری مشخص و بررسی شود.

---

# 25. موارد باز / نیازمند تأیید

این موارد مانع شروع توسعه نیستند، اما قبل از Production باید بسته شوند:

- فایل Certificate متناظر با کلید خصوصی فعلی.
- اعتبار زمانی Certificate.
- وضعیت FiscalId فعلی در کارپوشه.
- حالت ارسال انتخاب‌شده برای FiscalId.
- نسخه جاری دستورالعمل صدور صورتحساب هنگام Go-Live.
- نسخه جاری جدول خطاها.
- SSTID نهایی برای هر CodeItem.
- نرخ VAT موثر برای هر Rule و بازه زمانی.
- سیاست دقیق برخورد با درآمدهای Exempt و OutOfScope در ارسال Type 2.
- روش نهایی ثبت پرداخت سناریوی شرکت/اداره پس از صدور نسیه.

---

# 26. Roadmap اجرایی توسعه

## فاز 0 — تثبیت مرجع

- ثبت PKB
- تثبیت اسناد رسمی
- پیدا کردن Certificate
- کنترل FiscalId

## فاز 1 — Skeleton نرم‌افزار

- Solution جدید
- پروژه‌های Web/Application/Domain/Infrastructure
- EF Core
- SQL Server
- Logging
- Configuration

## فاز 2 — Data Model

- MoadianInvoice
- MoadianInvoiceItem
- MoadianTransmission
- MoadianInquiry
- MoadianRevenueRule
- MoadianSequence

## فاز 3 — Rule Engine

- CodeItem mapping
- VAT calculation
- SSTID mapping
- validation

## فاز 4 — Invoice Builder

- Type 1
- Type 2
- Header totals
- Body items
- Settlement rules

## فاز 5 — Moadian V2 Core

- Nonce
- JWT/JWS auth token
- server-information
- TaxId
- invoice JWS
- invoice JWE

## فاز 6 — Send + Inquiry

- Batch send
- UID/ReferenceNumber persistence
- inquiry
- error persistence
- retry policy

## فاز 7 — UI سناریوی شرکت‌ها

- فرم نوع ۱
- preview
- send
- inquiry

## فاز 8 — UI وصول روزانه

- read tblpardakht
- filter date
- rule mapping
- validation
- batch send
- status

## فاز 9 — Production Hardening

- Secret management
- permissions
- audit
- concurrency
- indexes
- monitoring
- backup
- failure recovery

## فاز 10 — Go-Live تدریجی

1. یک صورتحساب Type 1 کنترل‌شده
2. یک صورتحساب Type 2 کنترل‌شده
3. Batch کوچک
4. یک روز کامل وصول
5. پایش خطاها
6. فعال‌سازی عملیاتی روزانه

---

# 27. Definition of Done برای اتصال پایه

هسته اتصال زمانی «کامل» تلقی می‌شود که:

- Nonce واقعی گرفته شود.
- JWT معتبر ساخته شود.
- server-information موفق باشد.
- Public Key دریافت شود.
- TaxId معتبر تولید شود.
- Invoice JSON معتبر ساخته شود.
- JWS ساخته شود.
- JWE ساخته شود.
- POST invoice موفق باشد.
- UID و ReferenceNumber ذخیره شوند.
- Inquiry انجام شود.
- وضعیت نهایی ثبت شود.
- یک صورتحساب در کارپوشه سامانه مودیان قابل مشاهده باشد.

---

# 28. اصل نگهداری PKB

این فایل باید با پروژه زنده بماند.

هر تصمیم جدید مهم باید در همین فایل یا سند مرتبط ثبت شود، خصوصاً:

- تغییر مستندات رسمی
- تغییر API
- تغییر نرخ VAT
- تغییر SSTID
- تغییر ساختار دیتابیس شهرداری
- تجربه خطاهای Production
- تصمیم معماری جدید

این فایل «حافظه فنی و کسب‌وکاری پروژه» است و باید قبل از تغییرات بزرگ مطالعه شود.

---

# 29. مرجع کدهای قدیمی داخل Repository

برای مطالعه و استخراج دانش:

- `repos/SM2/Form1.cs`
- `repos/SM2/SM2.csproj`
- `repos/SM2/Models/ViewPardakhtMn.cs`
- `repos/SM2/Models/Tblpardakht.cs`
- `repos/SM2/Models/MunicipalityDbContext.cs`
- `Tba/SamaneMoadian/Moadian-master/Moadian-master/`

کد قدیمی نباید بدون بازبینی رسمی به پروژه جدید Copy/Paste شود.

---

# 30. خلاصه نهایی معماری

```text
سناریوی 1: شرکت/اداره
Form → Type 1 Invoice ┐
                      │
                      ▼
              Common Invoice Engine
                      │
سناریوی 2: شهروند     │
tblpardakht → Rules → Type 2 Invoice
                      │
                      ▼
                 TaxId
                      │
                      ▼
             Nonce + Auth JWS
                      │
                      ▼
            Server Public Key
                      │
                      ▼
              Invoice JWS
                      │
                      ▼
              Invoice JWE
                      │
                      ▼
             Moadian API V2
                      │
                      ▼
          UID + ReferenceNumber
                      │
                      ▼
                  Inquiry
                      │
                      ▼
            Final Status / Error
                      │
                      ▼
          Local Audit & Persistence
```

---

**این PKB مرجع فعلی ساخت نرم‌افزار تحت وب اتصال شهرداری ساری به سامانه مودیان است.**
