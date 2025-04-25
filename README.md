# STREAM in C# (LINQ)

- Is an **Abstraction** over data  
- Focus on the **Overall Picture**, not the individual loop  
- Helps **Avoid Errors** and makes Unit Tests simpler  

---

## 🔹 How to Use LINQ (C# Streams)

### Start with Collection:

```csharp
// Arrays
string[] cars = { "Volvo", "BMW", "Ford" };

// List
List<string> carsList = new List<string> { "Volvo", "BMW", "Ford" };

// Dictionary (similar to Java Map)
Dictionary<string, int> scores = new Dictionary<string, int>
{
    { "Alice", 90 },
    { "Bob", 85 }
};

```
## 🔸 Abstraction Phase – Intermediate Operations
![Java Stream vs C# LINQ](https://raw.githubusercontent.com/AmirZaafouri/Stream_in_JAVA/main/image-1.png)
### All methode IEnumerable return type in JAVA stream:
```csharp
// Example: Select cars that start with 'B' and convert to uppercase
var query = carsList
    .Where(car => car.StartsWith("B"))   // Filter (like Java's filter)
    .Select(car => car.ToUpper());       // Map (like Java's map)
```
```csharp
// Another example: Filter numbers and double them
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

var doubledEvens = numbers
    .Where(n => n % 2 == 0)       // Only even numbers
    .Select(n => n * 2);          // Double each
```

## 🔸 Go Back to Your Original Type – Terminal Operations
```csharp
// Convert the filtered/mapped query to a List
var result = carsList
    .Where(car => car.StartsWith("B"))
    .Select(car => car.ToUpper())
    .ToList(); // Terminal Operation: Collect

// Display each item
result.ForEach(car => Console.WriteLine(car)); // Terminal Operation: ForEach

```
```csharp
// Terminal Operation: Count, Sum, Any
int count = numbers.Where(n => n > 2).Count();
int sum = numbers.Select(n => n * 2).Sum();
bool hasBigNumber = numbers.Any(n => n > 10);
```
# ✅ Summary
Java Stream	C# LINQ
| Java Stream                         | C# LINQ                             |
|-------------------------------------|-------------------------------------|
| `.stream()`                         | `.AsEnumerable()` or just collection |
| `.filter(x -> ...)`                | `.Where(x => ...)`                  |
| `.map(x -> ...)`                   | `.Select(x => ...)`                 |
| `.collect(Collectors.toList())`    | `.ToList()`                         |
| `.forEach(...)`                    | `.ForEach(...)` (with List)         |
| `.count()`, `.anyMatch(...)`       | `.Count()`, `.Any(...)`             |
| `.reduce(...)`                     | `.Aggregate(...)`                   |


