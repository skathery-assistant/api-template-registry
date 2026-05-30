# Clean API template content

This folder contains the scaffold that template consumers will copy into a new ASP.NET Core API.

## What is included

- Minimal API entrypoint with grouped routes
- Centralized logging setup with structured request logs
- Security headers and HTTPS defaults
- Manual request validation with `Results.ValidationProblem`
- In-memory data store for the first-template experience
- Analyzer- and SonarQube-friendly project settings
- Example tests for validation and store behavior

## Recommended usage

1. Copy the template into a new repository or generator output folder.
2. Restore and build with the .NET 10 SDK.
3. Extend the widget feature or replace it with your actual domain.
4. Keep the logging, security, and validation baseline in place.

## Design goals

- Small enough to understand in one sitting
- Strong defaults without heavy framework ceremony
- Easy to fork into a real service
- Ready for CI, code review, and SonarQube-style quality gates
