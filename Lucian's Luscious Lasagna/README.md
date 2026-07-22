# 🍕 Lucian's Luscious Lasagna

A simple C# class that helps Lucian calculate cooking times for his perfect lasagna.

## 📋 Features

- **Expected oven time** - Returns the standard 40 minutes cooking time
- **Remaining oven time** - Calculates how many more minutes the lasagna needs
- **Preparation time** - Computes prep time based on number of layers (2 minutes per layer)
- **Total elapsed time** - Sums preparation and oven time

## 🚀 Quick Start

```csharp
var lasagna = new Lasagna();

// Expected oven time: 40 minutes
lasagna.ExpectedMinutesInOven(); // => 40

// Remaining time after 30 minutes in oven: 10 minutes
lasagna.RemainingMinutesInOven(30); // => 10

// Preparation time for 2 layers: 4 minutes
lasagna.PreparationTimeInMinutes(2); // => 4

// Total time for 3 layers and 20 minutes in oven: 26 minutes
lasagna.ElapsedTimeInMinutes(3, 20); // => 26
```

## 🛠️ Usage

Run the program to see the calculations:

```bash
dotnet run
```

**Output:**
```
Expected Minutes In Oven : 40
Remaining Minutes In Oven : 10
Preparation Time In Minutes : 4
Elapsed Time In Minutes : 26
```

## 📚 Reference

This code is a solution to the **Lucian's Luscious Lasagna** exercise on [Exercism's C# track](https://exercism.org/tracks/csharp/exercises/lucians-luscious-lasagna/), which teaches fundamental C# concepts including:
- Classes and methods
- Parameters and return values
- Basic arithmetic operations

## 📝 License

MIT © 2026
