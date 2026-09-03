# PKB — Project Knowledge Base

## سامانه تحت وب اتصال شهرداری ساری به سامانه مودیان

> وضعیت سند: مرجع اصلی دانش پروژه و نقشه راه ساخت
>
> هدف: ثبت دانش کسب‌وکاری، تصمیمات فنی، قواعد صدور صورتحساب، جریان اتصال به API V2 سامانه مودیان، ساختار داده، نیازمندی‌های عملیاتی و مسیر توسعه نرم‌افزار جدید شهرداری ساری.
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

قاعده پروژه: هرجا بین کد قدیمی و سند رسمی جاری اختلاف وجود داشته باشد، سند رسمی جاری مرجع است.

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
- `Inp = 1` : الگوی فروش کالا/خدمت تا زمانی که سند جاری برای خدمت خاص الگوی دیگری تعیین نکرده باشد
- `Ins = 1` : صورتحساب اصلی
- اطلاعات فروشنده: شهرداری ساری
- اطلاعات خریدار: شناسه اقتصادی/ملی شرکت یا اداره
- روش تسویه: بر اساس واقعیت معامله؛ در سناریوی قبل از پرداخت معمولاً نسیه یا نقدی/نسیه

### بعد از پرداخت

در صورتی که صورتحساب با روش نسیه یا نقدی/نسیه صادر شده باشد، API V2 سرویس ثبت پرداخت صورتحساب را نیز فراهم می‌کند. این موضوع با «ارسال روزانه وصول‌های شهروندی» متفاوت است.

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
5. جدول قواعد مالیاتی تعیین می‌کند درآمد مشمول، معاف یا خارج از مأخذ است.
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

این تجربه نشان می‌دهد در طراحی پروژه می‌توان برخی CodeItemهای هم‌ماهیت را به یک SSTID عمومی معتبر نگاشت کرد، مشروط به اینکه در زمان اجرا اعتبار و انطباق آن با فهرست جاری سامانه مودیان کنترل شود.

در نرم‌افزار جدید:

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

## 8.1 موجود یا شناخته‌شده

- Fiscal Memory ID قدیمی: `A3GAEA`
- شناسه اقتصادی شهرداری: `14002861227`
- Private Key قبلی در کد قدیمی موجود بوده است
- اتصال قبلی حداقل یک ارسال موفق واقعی داشته است
- Endpoint قبلی API قدیمی شناخته شده است
- Endpoint جدید API V2 از سند رسمی مشخص است

## 8.2 Certificate شهرداری برای V2

API V2 از گواهی امضا در فرآیند احراز هویت و امضای صورتحساب استفاده می‌کند.

Certificate باید معتبر باشد و قبل از Live Test موارد زیر درباره آن کنترل شود:

- تاریخ شروع و پایان اعتبار
- Subject
- Issuer
- Serial Number
- Thumbprint
- تعلق هویتی گواهی به شهرداری/شخص حقوقی مربوط
- انطباق کلید عمومی Certificate با Private Key مورد استفاده برنامه
- ثبت/معرفی گواهی یا کلید عمومی مربوط برای FiscalId در کارپوشه طبق روش ارسال انتخاب‌شده

### سیاست امنیتی

Private Key، Certificate Password و سایر Secrets نباید در Git Repository قرار گیرند.

در نرم‌افزار جدید Secrets باید از یکی از روش‌های امن مانند Secret Store / Environment Variable / Protected Configuration دریافت شوند.

Private Key قدیمی که در Repository عمومی قرار گرفته نباید برای Production به صورت پیش‌فرض امن فرض شود؛ تصمیم استفاده یا تعویض/صدور مجدد باید در مرحله راه‌اندازی رسمی با مسئول فنی و کارپوشه شهرداری گرفته شود.

---

# 9. نتیجه جست‌وجوی کامل Certificate در سورس لوکال و Repository

تاریخ ثبت نتیجه: ۱۴۰۵/۰۶/۱۲ (2026-09-03)

یک جست‌وجوی Read-Only در کل پروژه لوکال و زیرپوشه‌ها انجام شد و Git بدون تغییر باقی ماند.

## 9.1 فایل‌های Certificate/Key پیدا نشدند

هیچ فایل واقعی با پسوندهای زیر در پروژه پیدا نشد:

- `.crt`
- `.cer`
- `.pfx`
- `.p12`
- `.pem`
- `.key`
- `.der`
- `.p7b`
- `.p7c`

بنابراین Certificate واقعی شهرداری در Source Tree فعلی وجود ندارد.

## 9.2 مراجع رمزنگاری موجود در کد قدیمی

در کتابخانه قدیمی موارد زیر مشاهده شده‌اند:

### `EncryptionService.cs`

- مسیر Public Key را به عنوان ورودی دریافت می‌کند.
- محتوا را با `File.ReadAllText` از دیسک می‌خواند.
- با `ImportFromPem` وارد RSA می‌کند.
- فایل Public Key واقعی در Repository وجود ندارد.

### `SignatureService.cs`

- مسیر Private Key را دریافت می‌کند.
- فایل را با `File.ReadAllText` می‌خواند.
- با `ImportFromPem` وارد RSA می‌کند.
- فایل Private Key با پسوندهای مورد جست‌وجو در Source Tree وجود ندارد.

### `PemKeyUtils.cs`

- ابزار عمومی خواندن/پردازش PEM است.
- ثابت‌های `BEGIN ... KEY` در این فایل قالب‌شناسی هستند و Secret یا Certificate واقعی محسوب نمی‌شوند.

### `Moadian.cs`

- Public Key و Private Key را از پارامترهای سازنده دریافت می‌کند.
- Public Key را به EncryptionService و Private Key را به SignatureService می‌دهد.

### پروژه‌های مبتنی بر `TaxCollectData`

در فایل‌های نمونه `repos/SM/Form1.cs`، `repos/SM2/Form1.cs` و نمونه Tba، داده کلید مستقیماً به `SignatoryConfig` داده شده و Certificate فایل‌محور در Source مشاهده نشده است.

## 9.3 Windows Certificate Store

در سورس اجرایی استفاده‌ای از موارد زیر پیدا نشد:

- `X509Store`
- `StoreName`
- `StoreLocation`
- `X509Certificate`
- `X509Certificate2`

برخی Package/Assembly Referenceهای مرتبط با X509/PKCS#11 وجود دارند، اما در سورس فعلی استفاده عملی از Windows Certificate Store یا Registry برای بارگذاری Certificate پیدا نشد.

## 9.4 Config / DB / Environment

در بررسی انجام‌شده:

- appsettingsها مسیر یا Thumbprint گواهی ندارند.
- Web.configها تنظیم Certificate مربوط به مودیان ندارند.
- Certificate از Database بارگذاری نمی‌شود.
- Certificate از Registry بارگذاری نمی‌شود.
- Certificate از Environment Variable بارگذاری نمی‌شود.

## 9.5 نتیجه قطعی این جست‌وجو

Certificate واقعی در Repository یا Source Tree لوکال فعلی پیدا نشد.

بنابراین اقدام بعدی دیگر «جست‌وجوی Certificate داخل سورس» نیست. برای Live V2 باید Certificate معتبر از بیرون پروژه بازیابی، تمدید یا صادر و سپس در تنظیمات عملیاتی پروژه معرفی شود.

نکته: Public Key مورد استفاده EncryptionService نباید با Certificate شهرداری یکی فرض شود؛ این‌ها مفاهیم متفاوتی هستند و نقش هر کلید باید در پیاده‌سازی V2 مطابق سند رسمی روشن باشد.

---

# 10. روش تهیه و بستن چهار نیازمندی عملیاتی باقی‌مانده

این چهار مورد برای Go-Live باید بسته شوند. نبود آنها مانع طراحی و توسعه نرم‌افزار نیست، اما Certificate و FiscalId برای تست واقعی V2 حیاتی‌اند.

## 10.1 نیازمندی ۱ — Certificate معتبر شهرداری و تاریخ انقضا

### منبع/روش تهیه

طبق سند اتصال V2، کلید عمومی/گواهی امضا باید از مراکز میانی معتبر صدور گواهی الکترونیکی تهیه شده باشد. برای شهرداری به عنوان شخص حقوقی، اقدام عملی از مسیر گواهی سازمانی/مهر سازمانی معتبر انجام می‌شود.

### مسیر عملیاتی پیشنهادی

1. بررسی شود آیا شهرداری خارج از Source Tree گواهی جاری یا قبلی دارد؛ مثلاً نزد واحد IT، مسئول امضای الکترونیکی یا مسئول کارپوشه.
2. اگر گواهی موجود است، Metadata و تاریخ اعتبار آن خوانده شود.
3. انطباق Certificate با Private Key مورد استفاده بررسی شود.
4. اگر گواهی موجود نیست یا منقضی شده، شهرداری از مرکز میانی معتبر برای صدور/تمدید گواهی شخص حقوقی/مهر سازمانی اقدام کند.
5. در صورت تولید Key Pair جدید، نرم‌افزار باید با Private Key همان گواهی جدید تنظیم شود؛ Private Key قدیمی نباید به صورت خودکار با Certificate جدید جفت فرض شود.
6. گواهی/کلید عمومی مطابق حالت ارسال انتخاب‌شده در کارپوشه برای FiscalId معرفی/تأیید شود.
7. Secret واقعی فقط در محل امن عملیاتی نگهداری شود و وارد Git نشود.

### خروجی مورد انتظار

- Certificate معتبر
- Subject/Issuer/Thumbprint ثبت‌شده در تنظیمات غیرحساس سیستم
- تاریخ انقضا
- تأیید جفت بودن با Private Key
- وضعیت معرفی در کارپوشه

## 10.2 نیازمندی ۲ — تأیید نهایی FiscalId در کارپوشه

FiscalId شناخته‌شده از نمونه قدیمی:

`A3GAEA`

این مقدار به دلیل استفاده قبلی یک سرنخ قوی است، اما برای سیستم جدید باید در کارپوشه به صورت عملی کنترل شود.

### مسیر عملیاتی

1. ورود مسئول مجاز شهرداری به کارپوشه سامانه مودیان.
2. مراجعه به بخش عضویت/شناسه‌های یکتای حافظه مالیاتی.
3. جست‌وجو و کنترل `A3GAEA`.
4. بررسی اینکه شناسه متعلق به پرونده/مودی صحیح شهرداری است.
5. بررسی فعال بودن شناسه.
6. بررسی حالت ارسال اطلاعات برای این FiscalId.
7. بررسی وضعیت گواهی/کلید عمومی مرتبط با حالت ارسال.
8. اگر FiscalId قدیمی دیگر معتبر/قابل استفاده نیست، از همان فرآیند رسمی کارپوشه برای ایجاد/فعال‌سازی FiscalId مناسب استفاده شود.

### خروجی مورد انتظار

- FiscalId نهایی Production
- وضعیت Active/Usable
- Send Mode نهایی
- ارتباط تأییدشده با Certificate/Public Key

## 10.3 نیازمندی ۳ — فهرست نهایی SSTID برای CodeItemهای شهرداری

این مورد بخشی از آماده‌سازی داده و Rule Engine پروژه است و نیازمند خرید یا Secret نیست.

### مسیر تهیه

1. فهرست کامل `CodeItem`های شهرداری استخراج شود.
2. برای هر CodeItem عنوان و ماهیت درآمد مشخص شود.
3. وضعیت TaxTreatment از فایل/مصوبات معتبر شهرداری تعیین شود:
   - Taxable
   - Exempt
   - OutOfScope
4. فهرست جاری شناسه کالا/خدمت سامانه مودیان بررسی شود.
5. برای هر گروه از خدمات، SSTID عمومی یا اختصاصی معتبر و متناسب انتخاب شود.
6. در صورت امکان چند CodeItem هم‌ماهیت می‌توانند به یک SSTID عمومی معتبر نگاشت شوند.
7. `VatRate` و `UnitCode` مرتبط ثبت شوند.
8. نگاشت توسط واحد درآمد/مالی و مسئول پروژه تأیید شود.
9. نتیجه در `MoadianRevenueRule` وارد شود؛ نه در سورس کد.

### نمونه ساختار

```text
CodeItem → RevenueTitle → TaxTreatment → SSTID → SSTIDTitle → VatRate → UnitCode → EffectiveFrom/To
```

نمونه قدیمی `2330001031184` صرفاً یک Reference عملی است و قبل از استفاده Production باید اعتبار جاری و تناسب آن کنترل شود.

## 10.4 نیازمندی ۴ — نسخه جاری قواعد و نرخ‌ها در زمان Go-Live

این مورد یک Checkpoint نهایی است، نه یک فایل ثابت که یک‌بار تهیه شود و همیشه معتبر بماند.

### Go-Live Review باید کنترل کند

- نسخه جاری دستورالعمل فنی اتصال/API
- نسخه جاری دستورالعمل صدور صورتحساب و الگوها
- نسخه جاری سند TaxId
- نسخه جاری کدخطاها
- فعال و معتبر بودن SSTIDهای استفاده‌شده
- نرخ VAT موثر برای تاریخ عملیات
- وضعیت معاف/خارج از مأخذ برای کدهای درآمدی
- الزامات Type 1 و Type 2
- روش تسویه و قواعد پرداخت

### اصل طراحی

هیچ نرخ مالیاتی، SSTID یا قاعده متغیر قانونی نباید به شکل غیرقابل تغییر در Source Code قفل شود. Ruleها باید تاریخ اثر داشته باشند تا تغییر مقررات باعث نیاز به تغییر کد پایه نشود.

## 10.5 تفکیک Blockerها

### مانع شروع توسعه نیستند

- تکمیل تمام SSTIDها
- کنترل نهایی نرخ‌ها در تاریخ Go-Live
- Certificate نهایی برای نوشتن Skeleton و Core با Test Double
- تأیید FiscalId برای توسعه داخلی

### مانع Live Test واقعی V2 هستند

- نداشتن Certificate معتبر و قابل استفاده مطابق V2
- مشخص نبودن FiscalId قابل استفاده و حالت ارسال آن در کارپوشه

### مانع Production هستند

- ناقص بودن Mappingهای SSTID/CodeItem مورد استفاده
- کنترل نشدن نرخ‌ها و قواعد جاری
- نبود Audit/Retry/Idempotency/Security مناسب

---

# 11. معماری مفهومی سیستم

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

# 12. جریان رسمی API V2

## 12.1 دریافت Nonce

Endpoint:

`GET /requestsmanager/api/v2/nonce`

Nonce:

- یکبارمصرف است.
- زمان اعتبار محدود دارد.
- TTL پیش‌فرض در سند ۳۰ ثانیه است.
- برای تولید توکن احراز هویت استفاده می‌شود.

## 12.2 ساخت توکن احراز هویت

Payload اصلی:

- `nonce`
- `clientId`

برای مودی، `clientId` همان Fiscal Memory ID است.

توکن با استاندارد JWS و الگوریتم RS256 امضا می‌شود.

گواهی امضا در Header قرار می‌گیرد.

اصل مهم سند V2:

هر درخواست نیازمند فرآیند احراز هویت مربوط به خودش است و Token یک‌بارمصرف است.

## 12.3 دریافت اطلاعات سرور

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

## 12.4 تولید TaxId

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

## 12.5 ساخت JSON صورتحساب

ساختار رسمی:

```text
Invoice
 ├── header
 ├── body[]
 └── payments[]
```

## 12.6 امضای صورتحساب — JWS

صورتحساب JSON با Private Key شهرداری امضا می‌شود.

JWS Header شامل اطلاعاتی مانند:

- `alg = RS256`
- `x5c`
- `sigT`
- `crit`

است.

## 12.7 رمزگذاری صورتحساب — JWE

صورتحساب امضاشده با کلید عمومی سازمان مالیاتی رمز می‌شود.

الگوریتم‌های اصلی سند:

- `RSA-OAEP-256`
- `A256GCM`

خروجی، Payload رمزشده JWE است.

## 12.8 ارسال صورتحساب

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

## 12.9 پاسخ ارسال

برای هر صورتحساب پاسخ شامل:

- `uid`
- `referenceNumber`

است.

دریافت ReferenceNumber به معنی پذیرش نهایی صورتحساب نیست.

## 12.10 استعلام پردازش

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

## 12.11 وضعیت نهایی در کارپوشه

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

# 13. ساختار Header و Body مورد نیاز پروژه

## 13.1 Header — فیلدهای مهم

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

## 13.2 Body — فیلدهای مهم

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

# 14. طراحی دیتابیس پیشنهادی

`tblpardakht` منبع وصول شهرداری باقی می‌ماند و نباید به جدول اصلی مدیریت مودیان تبدیل شود.

## 14.1 MoadianInvoice

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

## 14.2 MoadianInvoiceItem

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

## 14.3 MoadianTransmission

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

## 14.4 MoadianInquiry

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

## 14.5 MoadianRevenueRule

جدول نگاشت CodeItem به قواعد مودیان که در بخش قبل توضیح داده شد.

## 14.6 MoadianSequence

برای تولید سریال غیرتکراری TaxId.

- `Id`
- `FiscalId`
- `LastSerial`
- `UpdatedAt`

استفاده از تراکنش/Sequence دیتابیس برای جلوگیری از تکرار ضروری است.

---

# 15. وضعیت‌های داخلی پیشنهادی

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

# 16. جلوگیری از ارسال تکراری

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

# 17. Batch روزانه وصول‌ها

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

# 18. رابط کاربری پیشنهادی

نرم‌افزار تحت وب حداقل این صفحات را نیاز دارد:

## 18.1 داشبورد

نمایش:

- تعداد صورتحساب امروز
- آماده ارسال
- ارسال‌شده
- در حال پردازش
- تأییدشده
- ردشده
- نیازمند بررسی

## 18.2 صدور صورتحساب شرکت/اداره

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

## 18.3 وصول‌های روزانه

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

## 18.4 پیگیری صورتحساب‌ها

فیلتر بر اساس:

- تاریخ
- TaxId
- ReferenceNumber
- CodeItem
- نوع صورتحساب
- وضعیت داخلی
- وضعیت مودیان

## 18.5 مدیریت قواعد درآمد

CRUD برای:

- CodeItem
- وضعیت مالیاتی
- SSTID
- نرخ VAT
- تاریخ اعتبار

## 18.6 تنظیمات اتصال

- FiscalId
- Seller Economic Code
- Environment
- Certificate metadata
- وضعیت اتصال

Secret واقعی در UI نمایش داده نشود.

---

# 19. معماری نرم‌افزار پیشنهادی

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

# 20. سرویس‌های فنی اصلی

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

# 21. اعتبارسنجی قبل از ارسال

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
- Certificate منقضی نشده باشد.
- Certificate و Private Key با هم جفت باشند.

هدف: خطاهای قابل تشخیص را قبل از ارسال به مودیان پیدا کنیم.

---

# 22. Log و Audit

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

# 23. Retry Policy

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

# 24. امنیت

قواعد قطعی:

- هیچ Private Key جدیدی در Git ثبت نشود.
- Private Key قدیمی موجود در Repository برای Production امن تلقی نشود مگر پس از تصمیم و کنترل رسمی؛ ترجیح امنیتی، جایگزینی/چرخش Secret افشاشده است.
- Secretها به Configuration امن منتقل شوند.
- Certificate expiration مانیتور شود.
- دسترسی صفحه تنظیمات محدود باشد.
- ارسال و مشاهده Logهای حساس Role-based باشد.
- HTTPS اجباری باشد.
- DB Credential در Source Code نباشد.
- Certificate Password نباید در Log یا Git ذخیره شود.

---

# 25. تست‌ها

## Unit Test

حداقل:

- محاسبه VAT
- محاسبه Header totals
- RevenueRule mapping
- Tax treatment
- TaxId serial logic
- Type 1 validation
- Type 2 validation
- Certificate/Key matching helper

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

1. دریافت Nonce واقعی
2. ساخت JWT/JWS معتبر
3. server-information
4. یک صورتحساب کنترل‌شده Type 1 یا Type 2
5. دریافت ReferenceNumber
6. Inquiry
7. مشاهده در کارپوشه

سپس Batch کوچک و بعد Batch واقعی.

---

# 26. تصمیمات قطعی تا این مرحله

1. پروژه جدید تحت وب است.
2. پروژه از صفر طراحی می‌شود.
3. کد قدیمی فقط Reference است.
4. دو سناریوی اصلی داریم: Type 1 قبل از پرداخت و Type 2 برای وصول‌های روزانه.
5. `tblpardakht` منبع وصول است، نه دیتابیس اصلی مودیان.
6. وضعیت مودیان در جداول مستقل ذخیره می‌شود.
7. CodeItem مبنای نگاشت درآمد به قواعد مالیاتی است.
8. Tax/VAT Ruleها Hard-code نمی‌شوند.
9. SSTID Hard-code نمی‌شود.
10. امکان نگاشت چند CodeItem هم‌ماهیت به SSTID عمومی معتبر وجود دارد؛ نمونه قدیمی از `2330001031184` استفاده کرده است، ولی اعتبار جاری باید قبل از Production کنترل شود.
11. هر وصول یک صورتحساب مستقل دارد؛ Batch صرفاً روش انتقال چند صورتحساب در یک Request است.
12. API هدف، V2 است.
13. Nonce/Token بر اساس قواعد V2 مدیریت می‌شود.
14. JWS و JWE طبق سند رسمی تولید می‌شوند.
15. ReferenceNumber پایان فرآیند نیست؛ Inquiry اجباری است.
16. TaxId و RequestTraceId باید یکتا باشند.
17. Secrets در Source Code ذخیره نمی‌شوند.
18. جست‌وجوی کامل Repository و Source Tree لوکال انجام شده و Certificate واقعی پیدا نشده است.
19. Certificate موردنیاز Live V2 باید خارج از سورس بازیابی، تمدید یا صادر شود.
20. `A3GAEA` باید قبل از Live Test در کارپوشه به صورت عملی تأیید شود.
21. SSTIDها و نرخ‌ها باید Configuration/Rule داده‌محور و تاریخ‌دار باشند.
22. Go-Live باید با کنترل نسخه جاری اسناد و نرخ‌ها انجام شود.

---

# 27. موارد باز / نیازمند تأیید

این موارد مانع شروع توسعه نیستند، اما قبل از Production باید بسته شوند:

- تهیه/بازیابی/صدور Certificate معتبر V2 و ثبت Metadata آن.
- کنترل انطباق Certificate با Private Key مورد استفاده.
- اعتبار زمانی Certificate.
- وضعیت FiscalId `A3GAEA` یا FiscalId جایگزین در کارپوشه.
- حالت ارسال انتخاب‌شده برای FiscalId.
- ارتباط Certificate/Public Key با FiscalId و Send Mode.
- نسخه جاری دستورالعمل صدور صورتحساب هنگام Go-Live.
- نسخه جاری جدول خطاها.
- SSTID نهایی برای CodeItemهای مورد استفاده.
- نرخ VAT موثر برای هر Rule و بازه زمانی.
- سیاست دقیق برخورد با درآمدهای Exempt و OutOfScope در ارسال Type 2.
- روش نهایی ثبت پرداخت سناریوی شرکت/اداره پس از صدور نسیه.

یادداشت وضعیت: «پیدا کردن Certificate داخل Repository/Source Tree» دیگر یک کار باز نیست؛ این جست‌وجو انجام شده و نتیجه منفی بوده است. کار باز اکنون «تهیه یا بازیابی Certificate معتبر خارج از سورس» است.

---

# 28. Roadmap اجرایی توسعه

## فاز 0 — تثبیت مرجع و Preflight

- ثبت و نگهداری PKB
- تثبیت اسناد رسمی فعلی
- ثبت نتیجه جست‌وجوی Certificate در سورس
- هماهنگی برای تهیه/بازیابی Certificate معتبر
- کنترل FiscalId در کارپوشه
- استخراج فهرست CodeItemهای هدف اولیه

## فاز 1 — Skeleton نرم‌افزار

- Solution جدید
- پروژه‌های Web/Application/Domain/Infrastructure
- EF Core
- SQL Server
- Logging
- Configuration
- Secret Provider abstraction

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
- EffectiveFrom/EffectiveTo برای قواعد

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
- Certificate loading/validation
- invoice JWS
- invoice JWE

## فاز 6 — Send + Inquiry

- Batch send
- UID/ReferenceNumber persistence
- inquiry
- error persistence
- retry policy
- idempotency

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
- Certificate expiry alert
- backup
- failure recovery

## فاز 10 — Go-Live Review

قبل از ارسال واقعی گسترده:

- Certificate معتبر و جفت با Private Key
- FiscalId و Send Mode تأییدشده در کارپوشه
- SSTIDهای مورد استفاده تأییدشده
- نرخ‌ها/TaxTreatmentهای تاریخ جاری تأییدشده
- نسخه‌های اسناد رسمی کنترل‌شده
- خطاها و Mappingهای شناخته‌شده به‌روز

## فاز 11 — Go-Live تدریجی

1. یک صورتحساب Type 1 کنترل‌شده
2. یک صورتحساب Type 2 کنترل‌شده
3. Batch کوچک
4. یک روز کامل وصول
5. پایش خطاها
6. فعال‌سازی عملیاتی روزانه

---

# 29. Definition of Done برای اتصال پایه

هسته اتصال زمانی «کامل» تلقی می‌شود که:

- Nonce واقعی گرفته شود.
- JWT معتبر ساخته شود.
- Certificate معتبر بارگذاری و کنترل شود.
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

# 30. اصل نگهداری PKB

این فایل باید با پروژه زنده بماند.

هر تصمیم جدید مهم باید در همین فایل یا سند مرتبط ثبت شود، خصوصاً:

- تغییر مستندات رسمی
- تغییر API
- تغییر نرخ VAT
- تغییر SSTID
- تغییر ساختار دیتابیس شهرداری
- تجربه خطاهای Production
- تصمیم معماری جدید
- تغییر Certificate/FiscalId/Send Mode
- نتایج تست واقعی و خطاهای API

این فایل «حافظه فنی و کسب‌وکاری پروژه» است و باید قبل از تغییرات بزرگ مطالعه شود.

---

# 31. مرجع کدهای قدیمی داخل Repository

برای مطالعه و استخراج دانش:

- `repos/SM2/Form1.cs`
- `repos/SM2/SM2.csproj`
- `repos/SM2/Models/ViewPardakhtMn.cs`
- `repos/SM2/Models/Tblpardakht.cs`
- `repos/SM2/Models/MunicipalityDbContext.cs`
- `repos/SM/Form1.cs`
- `Tba/SamaneMoadian/Moadian-master/Moadian-master/`
- `Tba/SamaneMoadian/Moadian-master/Moadian-master/Services/EncryptionService.cs`
- `Tba/SamaneMoadian/Moadian-master/Moadian-master/Services/SignatureService.cs`
- `Tba/SamaneMoadian/Moadian-master/Moadian-master/Services/PemKeyUtils.cs`
- `Tba/SamaneMoadian/Moadian-master/Moadian-master/Moadian.cs`

کد قدیمی نباید بدون بازبینی رسمی به پروژه جدید Copy/Paste شود.

---

# 32. خلاصه نهایی معماری و پیش‌نیازهای عملیاتی

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
       Certificate + Private Key
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

چهار پیش‌نیاز Go-Live:

```text
1) Certificate معتبر + Private Key متناظر
2) FiscalId فعال و Send Mode تأییدشده در کارپوشه
3) CodeItem → SSTID/TaxTreatment/VAT Mapping کامل برای دامنه عملیاتی
4) Go-Live Review روی نسخه جاری اسناد، SSTIDها و نرخ‌ها
```

---

**این PKB مرجع فعلی ساخت نرم‌افزار تحت وب اتصال شهرداری ساری به سامانه مودیان است. هر یافته اجرایی جدید باید به همین سند اضافه شود.**