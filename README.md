# C# Type Conversion

A beginner-friendly C# Console Application demonstrating different types of type conversion with simple examples.

---

## 📌 Project Overview

This project explains the most commonly used type conversion techniques in C#. Each concept is implemented in a separate class to make the code easy to understand and maintain.

---

## ✨ Features

- ✅ Implicit Conversion
- ✅ Explicit Conversion (Casting)
- ✅ Convert Class
- ✅ Parse() Method
- ✅ TryParse() Method
- ✅ Console-based User Input
- ✅ Beginner-Friendly Code

---

## 📂 Project Structure

```
TypeConversion
│
├── Program.cs
├── ImplicitConversion.cs
├── ExplicitConversion.cs
├── ConvertClass.cs
├── ParseExample.cs
└── TryParseExample.cs
```

---

## 🛠️ Technologies Used

- C#
- .NET 10
- Visual Studio 2022

---

## 📖 Concepts Covered

### 1. Implicit Conversion
Automatically converts a smaller data type to a larger data type.

Example:

```csharp
int number = 100;
double value = number;
```

---

### 2. Explicit Conversion (Casting)
Manually converts a larger data type to a smaller data type.

```csharp
double price = 999.99;
int amount = (int)price;
```

---

### 3. Convert Class

```csharp
Convert.ToInt32();
Convert.ToDouble();
Convert.ToBoolean();
```

---

### 4. Parse()

```csharp
int age = int.Parse("23");
```

---

### 5. TryParse()

```csharp
int.TryParse(input, out int number);
```

---

## ▶️ Sample Output

```text
===== TYPE CONVERSION IN C# =====

1. Implicit Conversion
Integer Value : 100
Double Value  : 100

2. Explicit Conversion
Double Value : 999.99
Integer Value: 999

3. Convert Class
Enter First Number : 34
Enter Second Number : 66
Sum = 100

4. Parse Method
Enter Your Age : 23
Your Age is : 23

5. TryParse Method
Enter a Number : 12
Valid Number : 12

Program Completed Successfully.
```

---

## 🎯 Learning Outcomes

- Understand type conversion in C#
- Learn implicit and explicit conversions
- Convert strings to numeric data types
- Handle invalid user input safely using `TryParse()`
- Build structured console applications

---

## 👩‍💻 Author

**Pandi Vigneshwari T**

Aspiring .NET Developer

GitHub: https://github.com/pandi-vigneshwari

---

⭐ If you found this project helpful, please consider giving it a star.
