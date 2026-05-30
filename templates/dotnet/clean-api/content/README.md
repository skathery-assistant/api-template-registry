# Clean API template content

This folder contains the scaffold that template consumers will copy into a new ASP.NET Core API.

---

## English

### What is included

- Minimal API entrypoint with grouped routes
- Centralized logging setup with structured request logs
- Security headers and HTTPS defaults
- Manual request validation with `Results.ValidationProblem`
- In-memory data store for the first-template experience
- Analyzer- and SonarQube-friendly project settings
- Example tests for validation and store behavior

### Recommended usage

1. Copy the template into a new repository or generator output folder.
2. Restore and build with the .NET 10 SDK.
3. Extend the widget feature or replace it with your actual domain.
4. Keep the logging, security, and validation baseline in place.

### Design goals

- Small enough to understand in one sitting
- Strong defaults without heavy framework ceremony
- Easy to fork into a real service
- Ready for CI, code review, and SonarQube-style quality gates

### Practical notes

- Treat this content as a starting point, not a final product.
- Preserve the baseline security and validation behavior unless you have a clear reason to change it.
- Use the example tests as a pattern when you add new endpoints or domain rules.

---

## العربية

### ما الذي يتضمنه هذا المجلد؟

- نقطة دخول لـ Minimal API مع تقسيم المسارات إلى مجموعات
- إعداد مركزي للتسجيل مع سجلات منظمة للطلبات
- رؤوس أمان وإعدادات HTTPS الافتراضية
- تحقق يدوي من الطلبات باستخدام `Results.ValidationProblem`
- مخزن بيانات داخل الذاكرة لتجربة القالب الأولى
- إعدادات مناسبة لـ Analyzer وSonarQube
- اختبارات مثال للتحقق من السلوك وصحة المخزن

### طريقة الاستخدام الموصى بها

1. انسخ القالب إلى مستودع جديد أو إلى مجلد ناتج من أداة توليد.
2. نفّذ الاستعادة والبناء باستخدام ‎.NET 10 SDK.
3. وسّع ميزة الـ widget أو استبدلها بمجالك الحقيقي.
4. احتفظ بخط الأساس الخاص بالتسجيل والأمان والتحقق كما هو.

### أهداف التصميم

- صغير بما يكفي لفهمه في جلسة واحدة
- إعدادات افتراضية قوية من دون تعقيد إطار عمل زائد
- سهل التحويل إلى خدمة حقيقية لاحقًا
- جاهز لعمليات CI ومراجعة الكود وبوابات جودة على نمط SonarQube

### ملاحظات عملية

- اعتبر هذا المحتوى نقطة بداية وليس المنتج النهائي.
- حافظ على سلوك الأمان والتحقق الافتراضي ما لم يكن لديك سبب واضح لتغييره.
- استخدم اختبارات المثال كنمط عند إضافة endpoints جديدة أو قواعد مجال جديدة.
