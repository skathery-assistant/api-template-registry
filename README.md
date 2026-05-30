# Template Registry

A GitHub-based registry for reusable API templates.

---

## English

### Purpose

This repository is the source of truth for template definitions, documentation, and template assets.

### What this registry is for

- Keep template metadata in one place
- Document how each template should be used
- Store scaffold files that can be copied into new projects
- Make future automation and generation flows easier to add

### Current scope

- .NET API templates first
- Registry-driven metadata
- Security, logging, validation, and quality standards built in
- Future support for Python templates without changing the top-level structure

### Repository layout

- `registry.json` — machine-readable list of templates
- `templates/<language>/<template-name>/template.yml` — template metadata
- `templates/<language>/<template-name>/README.md` — human-readable docs
- `templates/<language>/<template-name>/content/` — template files and scaffolding

### Roadmap

1. Expand the first .NET API template into a generator-ready package
2. Add more template variants over time
3. Add governance notes for review, release, and quality gates

---

## العربية

### الغرض

هذا المستودع هو *المصدر المرجعي* لتعريفات القوالب، والوثائق، وأصول القوالب نفسها.

### ما الذي يقدمه هذا السجل؟

- تجميع بيانات القوالب في مكان واحد
- توضيح طريقة استخدام كل قالب بشكل واضح
- حفظ ملفات البناء الأولية التي يمكن نسخها إلى المشاريع الجديدة
- تسهيل أتمتة عمليات الإنشاء والتوليد لاحقًا

### النطاق الحالي

- البدء بقوالب .NET API
- اعتماد بيانات وصفية مرتبطة بالسجل
- تضمين الأمان، والسجلات، والتحقق، ومعايير الجودة من البداية
- إتاحة دعم قوالب Python لاحقًا دون تغيير البنية العليا للمستودع

### هيكل المستودع

- `registry.json` — قائمة القوالب بصيغة قابلة للقراءة آليًا
- `templates/<language>/<template-name>/template.yml` — البيانات الوصفية للقالب
- `templates/<language>/<template-name>/README.md` — توثيق بشري واضح
- `templates/<language>/<template-name>/content/` — ملفات القالب والبنية الأولية

### خارطة الطريق

1. تحويل أول قالب .NET API إلى حزمة جاهزة للتوليد الآلي
2. إضافة المزيد من القوالب مع الوقت
3. إضافة ملاحظات حوكمة للمراجعة والإصدار وبوابات الجودة
