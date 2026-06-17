# Public Portfolio Showcase

เอกสารชุดนี้เป็นเวอร์ชันสาธารณะสำหรับนำไปวางบน GitHub หรือแนบในโปรไฟล์การทำงาน โดยตั้งใจเล่าเฉพาะแนวคิดระบบ บทบาทที่ทำ เทคโนโลยี และผลลัพธ์เชิงวิศวกรรม

> หมายเหตุ: เอกสารนี้ไม่ใช่ source code production และไม่เปิดเผยข้อมูลภายในบริษัท เช่น connection string, ตารางจริงทั้งหมด, username/password, employee data, URL ภายใน, business rule เชิงลับ หรือข้อมูลลูกค้า

## Projects

### 1. WorkStatePE

ระบบติดตามสถานะการทำงานของพนักงานในสายการผลิต แยก flow สำหรับผู้ใช้ทั่วไปและผู้ดูแลระบบ รองรับ check-in/check-out, dashboard แบบ polling, การเปลี่ยนสถานะโดย admin, และ export report

- Stack: ASP.NET MVC, C#, SQL Server, Dapper, Razor, JavaScript, Bootstrap/AdminLTE, Selenium
- Architecture: Controller-Service-Repository, role-based authorization, JSON API สำหรับ dashboard
- Highlights:
  - Dashboard snapshot สำหรับแสดงสถานะพนักงานแบบใกล้ real-time
  - Check-in/check-out flow พร้อมบันทึก working minutes
  - Admin management สำหรับ employee, line, case, status
  - Automated UI smoke tests ด้วย Selenium console runner

อ่านรายละเอียด: [WorkStatePE Case Study](case-studies/workstatepe.md)

### 2. SubstanceSys

ระบบ HR สำหรับบันทึกและติดตามรายการ follow-up พร้อมการแจ้งเตือนอีเมลแบบกำหนดกลุ่มผู้รับ, CC, exclude และรอบแจ้งเตือนตามวัน/เวลา

- Stack: ASP.NET MVC, C#, SQL Server, Dapper, MailKit/MimeKit, Hangfire-compatible job flow
- Architecture: Controller-Service-Repository, schema initializer, background notification runner
- Highlights:
  - Form flow สำหรับบันทึก แก้ไข ลบ และยืนยันผล follow-up
  - Email configuration แยกกลุ่ม TO/CC/EXCLUDE
  - Scheduled และ periodic notification logic
  - Email send log สำหรับตรวจสอบสถานะ SUCCESS/FAILED/SKIPPED

อ่านรายละเอียด: [SubstanceSys Case Study](case-studies/substancesys.md)

## What Is Safe To Publish

- ภาพรวมระบบและปัญหาที่แก้
- Diagram ที่เปลี่ยนชื่อ entity/table ให้เป็น generic
- README, case study, architecture notes
- ตัวอย่าง code ที่เขียนใหม่เป็น generic sample
- Screenshot ที่ blur/แทนค่าข้อมูลจริงทั้งหมดแล้ว
- Test strategy และ workflow โดยใช้ test data

## What Must Not Be Published

- `Web.config`, connection strings, SMTP settings, API keys, credentials
- Source code production ทั้งก้อนโดยไม่ได้ตรวจ confidential data
- ชื่อพนักงาน, employee code จริง, email จริง, เบอร์โทร, รูปพนักงาน
- URL/domain ภายในบริษัท
- SQL query/table schema จริงที่เปิดเผยโครงสร้างภายในมากเกินไป
- log, Excel, export, screenshot, หรือ test result ที่มีข้อมูลจริง
- ชื่อบริษัท/ลูกค้า/ไลน์ผลิต/โปรเซสภายใน หากยังไม่ได้รับอนุญาต

## Recommended Public Repository Structure

```text
portfolio-enterprise-systems/
  README.md
  case-studies/
    workstatepe.md
    substancesys.md
  diagrams/
    workstatepe-flow.mmd
    substancesys-notification-flow.mmd
  samples/
    workstatepe-dashboard-api-sample.cs
    substancesys-notification-scheduler-sample.cs
  docs/
    public-disclosure-checklist.md
```

## Profile Summary

ตัวอย่างข้อความสั้นสำหรับโปรไฟล์:

> Developed internal enterprise web modules using ASP.NET MVC, C#, SQL Server, Dapper, and JavaScript. Key projects include a production work-state dashboard with check-in/check-out, role-based admin controls, export reporting, and Selenium UI automation, plus an HR follow-up notification system with configurable email groups, scheduled reminders, validation, and audit logging.
