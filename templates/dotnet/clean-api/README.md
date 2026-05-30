# dotnet-clean-api

A starter template for production-ready ASP.NET Core APIs.

---

## English

### Overview

`dotnet-clean-api` is a starter template for building clean, production-ready ASP.NET Core APIs.

It is designed to give you a strong default foundation without forcing a heavy architecture or too much ceremony on day one.

### Included in this iteration

- ASP.NET Core minimal API scaffold
- Structured logging baseline with request timing
- Security headers, HTTPS redirection, and HSTS defaults
- Validation pipeline with `Results.ValidationProblem`
- In-memory widget example to demonstrate clean structure
- Analyzer and style defaults that are SonarQube-friendly
- Example test project for validation and store behavior

### Why these pieces exist

- **Minimal API scaffold**: keeps the entrypoint small and easy to follow
- **Structured logging**: makes request tracing and troubleshooting easier
- **Security defaults**: gives you safer production behavior from the start
- **Validation pipeline**: returns consistent API errors when input is invalid
- **In-memory example**: shows how to organize code before adding a real persistence layer
- **Analyzer-friendly settings**: helps the project stay clean in CI and code review
- **Tests**: provide a working example of how the template should be verified

### Content layout

- `content/README.md` — usage and design notes
- `content/Directory.Build.props` — shared build and analyzer settings
- `content/.editorconfig` — formatting and style baseline
- `content/src/CleanApi/` — application project
- `content/tests/CleanApi.Tests/` — example test project

### How to read `template.yml`

`template.yml` is the machine-readable metadata file for this template.
It tells generator tools and registry consumers *what this template is*, *how to classify it*, and *what baseline capabilities it includes*.

- `name` — the template identifier used by the registry and automation
- `description` — a short summary of the template’s purpose and quality baseline
- `language` — the primary stack or ecosystem the template targets
- `version` — the template version, useful for release tracking and upgrades
- `tags` — search and filtering labels such as `api`, `security`, or `testing`
- `includes` — the baseline building blocks bundled with the template

#### Why these fields matter

- They make the template easy to discover in a registry UI or CLI
- They help automation decide how to present or filter templates
- They provide a compact contract between the human docs and the scaffold files
- They keep the registry consistent as more templates are added later

### Next steps

- Wire this template into your generator or scaffold flow
- Add CI to build and test the scaffold on a clean machine
- Extend the widget example into the real domain model

### `template.yml` explained in Arabic

`template.yml` هو ملف البيانات الوصفية المقروء آليًا لهذا القالب.

هو يوضح لأدوات التوليد والسجل البرمجي *ما هو هذا القالب*، و*كيف يتم تصنيفه*، و*ما هي القدرات الأساسية المضمّنة فيه*.

- `name` — اسم القالب الذي يستخدمه السجل والأتمتة
- `description` — وصف مختصر لهدف القالب ومستوى الجودة الذي يقدمه
- `language` — التقنية أو المنصة الأساسية التي يستهدفها القالب
- `version` — رقم إصدار القالب، ويفيد في التتبع والتحديثات
- `tags` — وسوم للبحث والتصفية مثل `api` أو `security` أو `testing`
- `includes` — المكونات الأساسية التي تأتي ضمن القالب

#### لماذا هذه الحقول مهمة؟

- تجعل القالب سهل الاكتشاف داخل واجهة سجل أو أداة CLI
- تساعد الأتمتة على عرض القوالب أو تصفيتها بشكل صحيح
- توفر عقدًا مختصرًا بين التوثيق البشري وملفات البناء
- تحافظ على اتساق السجل كلما تمت إضافة قوالب جديدة

---

## العربية

### نظرة عامة

`dotnet-clean-api` هو قالب بداية لبناء واجهات ASP.NET Core API نظيفة وجاهزة للإنتاج.

تم تصميمه ليمنحك أساسًا قويًا من البداية، من دون فرض بنية معقدة أو إجراءات زائدة في المرحلة الأولى.

### ما الذي يتضمنه هذا الإصدار؟

- هيكل أولي لـ ASP.NET Core Minimal API
- أساس تسجيل منظم مع قياس زمن الطلبات
- رؤوس أمان، وإعادة توجيه إلى HTTPS، وإعدادات HSTS الافتراضية
- مسار تحقق يستخدم `Results.ValidationProblem`
- مثال ذاكرة داخلية لإظهار بنية نظيفة وواضحة
- إعدادات Analyzer وStyle مناسبة لبيئات SonarQube
- مشروع اختبارات كمثال للتحقق من صحة المدخلات وسلوك المخزن

### لماذا هذه الأجزاء موجودة؟

- **هيكل Minimal API**: يجعل نقطة الدخول صغيرة وسهلة القراءة
- **التسجيل المنظم**: يسهل تتبع الطلبات وتشخيص المشاكل
- **إعدادات الأمان**: تمنحك سلوكًا أكثر أمانًا في بيئة الإنتاج منذ البداية
- **مسار التحقق**: يعيد أخطاء API متسقة عند وجود مدخلات غير صحيحة
- **المثال الداخلي للذاكرة**: يوضح طريقة تنظيم الكود قبل إضافة قاعدة بيانات حقيقية
- **إعدادات التحليل**: تساعد على إبقاء المشروع نظيفًا في CI ومراجعة الكود
- **الاختبارات**: تقدم مثالًا عمليًا على كيفية التحقق من القالب

### هيكل المحتوى

- `content/README.md` — ملاحظات الاستخدام والتصميم
- `content/Directory.Build.props` — إعدادات البناء والتحليل المشتركة
- `content/.editorconfig` — أساس التنسيق وأسلوب الكتابة
- `content/src/CleanApi/` — مشروع التطبيق
- `content/tests/CleanApi.Tests/` — مشروع الاختبارات كمثال

### الخطوات التالية

- ربط القالب بأداة التوليد أو مسار الإنشاء الخاص بك
- إضافة CI لبناء القالب واختباره على جهاز نظيف
- توسيع مثال الـ widget ليصبح نموذج المجال الحقيقي
