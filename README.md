# C# Type Conversion

## 📖 Overview

This project demonstrates the different types of type conversion in C# using a simple Console Application. It is designed for beginners to understand how data can be converted between different data types safely and efficiently.

---

## 🚀 Features

- Implicit Type Conversion
- Explicit Type Conversion (Casting)
- Convert Class
- Parse() Method
- TryParse() Method
- Console-based User Interaction
- Beginner-Friendly Code Structure

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

## 🛠 Technologies Used

- C#
- .NET 10
- Visual Studio 2022

---

## 📚 Concepts Covered

### 1. Implicit Conversion
Automatically converts a smaller data type to a larger data type.

Example:
```
int number = 100;
double value = number;
```

### 2. Explicit Conversion (Casting)
Manually converts a larger data type to a smaller data type.

Example:
```
double price = 999.99;
int amount = (int)price;
```

### 3. Convert Class
Converts one data type to another using built-in methods.

Example:
```
Convert.ToInt32()
Convert.ToDouble()
Convert.ToBoolean()
```

### 4. Parse()
Converts a string into its corresponding data type.

Example:
```
int age = int.Parse("23");
```

### 5. TryParse()
Safely converts a string into a data type without throwing an exception for invalid input.

Example:
```
int.TryParse(input, out int number);
```

---

## ▶️ Sample Output

```
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

- Understand different types of type conversion in C#
- Learn automatic and manual type conversion
- Convert string values into numeric data types
- Handle invalid user input using TryParse()
- Build beginner-friendly console applications

---

## 👩‍💻 Author

**Pandi Vigneshwari T**

Aspiring .NET Developer

GitHub: https://github.com/pandi-vigneshwari

---

⭐ If you found this project helpful, consider giving it a star!
