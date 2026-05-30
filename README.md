# Template Registry

A GitHub-based registry for reusable API templates.

## Purpose

This repository is the source of truth for template definitions, documentation, and template assets.

## Current scope

- .NET API templates first
- Registry-driven metadata
- Security, logging, validation, and quality standards built in
- Future support for Python templates without changing the top-level structure

## Repository layout

- `registry.json` — machine-readable list of templates
- `templates/<language>/<template-name>/template.yml` — template metadata
- `templates/<language>/<template-name>/README.md` — human-readable docs
- `templates/<language>/<template-name>/content/` — template files and scaffolding

## Roadmap

1. Expand the first .NET API template into a generator-ready package
2. Add more template variants over time
3. Add governance notes for review, release, and quality gates
