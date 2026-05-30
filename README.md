# Template Registry

A GitHub-based registry for reusable API templates.

## Purpose

This repository is the source of truth for template definitions, documentation, and future template assets.

## Current scope

- .NET API templates first
- Registry-driven metadata
- Security, logging, and quality standards built in
- Future support for Python templates without changing the top-level structure

## Repository layout

- `registry.json` — machine-readable list of templates
- `templates/<language>/<template-name>/template.yml` — template metadata
- `templates/<language>/<template-name>/README.md` — human-readable docs
- `templates/<language>/<template-name>/content/` — template files and scaffolding

## Roadmap

1. Define the first .NET API template
2. Add a standardized metadata schema
3. Add security and quality baseline docs
4. Add more template variants over time
