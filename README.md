# CSRF Vulnerability Demo in ASP.NET MVC (C#)

This repository demonstrates a Cross-Site Request Forgery (CSRF) vulnerability in a simple ASP.NET MVC web application.

## 🔓 Vulnerable Version

The `VulnerableApp` project contains a form to update the user’s email **without CSRF protection**, allowing an attacker to forge requests on behalf of a logged-in user.

## 🛡️ Secure Version

The `SecureApp` adds CSRF protection using the `[ValidateAntiForgeryToken]` attribute and the `@Html.AntiForgeryToken()` helper in the view.

## 💀 Malicious Attack Page

`MaliciousPage/csrf-attack.html` contains a crafted form that simulates how an attacker could exploit the CSRF flaw in `VulnerableApp`.

> ⚠️ This project is for educational and demonstration purposes only.

---
