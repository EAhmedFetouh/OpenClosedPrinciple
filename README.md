🧩 Open/Closed Principle (OCP) — Example
This repository demonstrates the Open/Closed Principle (OCP), the second of the SOLID design principles in object-oriented programming.

📌 What is OCP?

Definition:

Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.

⚠ The Problem This Example Highlights

In the original implementation:

A DiscountCalculator class uses if-else or switch statements to apply discounts based on user type.

Adding a new discount type (e.g., "Platinum") requires modifying this class.

👉 This breaks OCP because:

The class must be modified every time we introduce a new discount rule.

This introduces risk of bugs, and violates the idea of stability in existing code.

✅ The Goal

Use polymorphism and strategy pattern to allow extension without modification:

Define a IDiscountStrategy interface

Implement different strategies: RegularDiscount, GoldDiscount, PlatinumDiscount, etc.

The calculator accepts strategies through composition or configuration.

➡ You can now add new discount types without changing the calculator itself.

💡 Why OCP matters

✅ Easier to extend
✅ Minimizes changes to stable, tested code
✅ Encourages modular, clean architecture
✅ Makes the system more maintainable

🚀 How to use

1️⃣ Clone the repo
2️⃣ Review the conditional logic in the old calculator
3️⃣ Review the strategy-based design
4️⃣ Try adding a new discount rule without touching the calculator code
