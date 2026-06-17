# Public Disclosure Checklist

ใช้ checklist นี้ก่อนนำข้อมูลขึ้น GitHub แบบ public

## Publish

- Case study ที่อธิบาย problem, role, stack, architecture, result
- Diagram ที่ใช้ชื่อ generic เช่น EmployeeReference, FollowUpRecord, DashboardSnapshot
- Code sample ที่เขียนใหม่และไม่อ้างอิงข้อมูลบริษัท
- Screenshot ที่ใช้ mock data และ blur โลโก้/ชื่อบริษัท/ชื่อคน/รหัสพนักงาน
- README ที่ระบุว่าเป็น sanitized portfolio project

## Do Not Publish

- `Web.config`, `*.config`, `.csproj.user`, `bin/`, `obj/`, `TestResults/`
- Connection string, SMTP, token, password, API key
- Employee code, employee name, email, phone, department จริง
- รูปพนักงานหรือ URL รูปจากระบบภายใน
- SQL script production ที่มี table/column จริงครบชุด
- Log หรือ Excel ที่ export จากระบบจริง
- ชื่อบริษัท ลูกค้า supplier line process หรือ business rule ที่อาจเป็น confidential

## Suggested GitHub Description

```text
Sanitized enterprise system case studies from ASP.NET MVC work: production work-state dashboard and HR notification workflow. No company data or production secrets included.
```

## Suggested Repository Topics

```text
aspnet-mvc csharp sql-server dapper enterprise-app dashboard notification-system selenium portfolio
```

## Final Review Before Public

- เปิด repo ใน private ก่อน
- อ่านทุกไฟล์ด้วยมุมมองคนภายนอก
- ค้นคำว่า password, connectionString, smtp, token, secret, employee, email, phone
- ตรวจ screenshot ทุกภาพ
- ให้หัวหน้าหรือผู้เกี่ยวข้องอนุมัติ หาก policy บริษัทต้องการ
