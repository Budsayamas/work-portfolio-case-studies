# Public Release Sanitization Checklist

Use this checklist before publishing any project derived from internal company work.

## Must Remove

- Real database connection strings.
- Internal IP addresses and server names.
- Usernames, passwords, access tokens, API keys, or certificates.
- Real database names, table names, stored procedure names, and function names if they reveal internal architecture.
- Employee names, employee IDs, department names, line names, or personal information.
- Company names, customer names, vendor names, and private process details.
- Excel templates or screenshots that contain real operational data.
- Build output folders: `bin/`, `obj/`, `publish/`, `app.publish/`.
- Compiled files: `.exe`, `.dll`, `.pdb`, `.deploy`.
- User-specific files: `.csproj.user`, `.pubxml.user`, `.suo`, `.vs/`.

## Safe To Share

- High-level problem statement.
- General architecture diagrams.
- Sanitized screenshots with fake data.
- Redacted code snippets that show patterns without secrets.
- Tech stack and your role.
- Lessons learned and business impact at a non-confidential level.

## Recommended GitHub Repository Shape

```text
README.md
.gitignore
docs/
  sanitization-checklist.md
  architecture.md
src-samples/
  EmployeeRecordService.sample.cs
  ReportExportService.sample.cs
```

## Extra Safety Step

If a real password was committed or shared anywhere, change it in the actual system. Removing it from GitHub later is not enough because public repository history can be copied quickly.
