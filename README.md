# Simple Banking System (C# Console Application)

A clean, modular, object-oriented **Banking System** built in **C# (.NET 9)**.  
This project demonstrates strong fundamentals of **OOP, separation of concerns, input validation, service-layer architecture, and error handling**.

It supports essential banking operations such as:

- Create Account  
- Deposit Money  
- Withdraw Money  
- Check Balance  
- View Account Details  
- List All Accounts  

---

## 🎯 Features

### ✔️ Modular Architecture
The project follows a clean multi-layer structure:
- **Models** — Data structures representing bank accounts.  
- **Services** — Business logic (BankService).  
- **Helpers** — Input validation utilities.  
- **Program.cs** — UI + control flow.

### ✔️ Strong Input Validation  
A reusable `InputValidator` class ensures:
- Only valid account numbers  
- Only valid positive amounts  
- Only valid names  
- Only allowed account types  

### ✔️ Fully OOP-Based
- Encapsulation  
- Data hiding  
- Reusable methods  
- Clear separation of concerns

### ✔️ No External Libraries
Runs directly with **.NET 9 SDK**.
---

## 📂 Project Structure
```
SimpleBankingSystem/
│
├── Models/
│ └── BankAccount.cs
│
├── Services/
│ └── BankService.cs
│
├── Helpers/
│ └── InputValidator.cs
│
├── Program.cs
└── README.md
```
---


## 🚀 Getting Started

### 1️⃣ Install .NET SDK (9.x recommended)
Download from:  
https://dotnet.microsoft.com/en-us/download

Verify installation:
```bash
dotnet --version
```

### ▶️ Running the Application
```bash
dotnet build
dotnet run
```


## 🧪 Sample Output
```
----- Simple Banking System -----
1. Create Account
2. Deposit Money
3. Withdraw Money
4. Check Balance
5. View Account Details
6. List All Accounts
7. Exit
---------------------------------
Enter your choice:
```

## 🤝 Contributing
Pull requests are welcome.
---


