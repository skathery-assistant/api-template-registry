# dotnet-clean-api

A starter template for production-ready ASP.NET Core APIs.

## Included in this iteration

- ASP.NET Core minimal API scaffold
- Structured logging baseline with request timing
- Security headers, HTTPS redirection, and HSTS defaults
- Validation pipeline with `Results.ValidationProblem`
- In-memory widget example to demonstrate clean structure
- Analyzer and style defaults that are SonarQube-friendly
- Example test project for validation and store behavior

## Content layout

- `content/README.md` — usage and design notes
- `content/Directory.Build.props` — shared build and analyzer settings
- `content/.editorconfig` — formatting and style baseline
- `content/src/CleanApi/` — application project
- `content/tests/CleanApi.Tests/` — example test project

## Next steps

- Wire this template into your generator or scaffold flow
- Add CI to build and test the scaffold on a clean machine
- Extend the widget example into the real domain model
