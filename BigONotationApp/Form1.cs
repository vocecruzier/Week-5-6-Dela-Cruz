namespace BigONotationApp;

public partial class Form1 : Form
{
    private enum InputKind { None, Number, Text }

    private record Exercise(int Topic, string Title, InputKind Kind, string DefaultInput, int Min, int Max,
                            Func<string, int, List<string>> Run);

    private readonly string[] complexityInfo =
    {
        "O(1) - Constant Time (Executes instantly in 1 step)",
        "O(n) - Linear Time (Steps grow in direct proportion to n)",
        "O(log n) - Logarithmic Time (Each step cuts the problem in half)",
        "O(n²) - Quadratic Time (A loop inside a loop: n x n steps)",
        "O(2^n) - Exponential Time (Steps double every time n goes up by 1)"
    };

    private List<Exercise> exercises = new();
    private List<Exercise> shown = new();

    public Form1()
    {
        InitializeComponent();
        BuildExercises();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        cmbTopic.SelectedIndex = 0;
    }

    private void CmbTopic_SelectedIndexChanged(object? sender, EventArgs e)
    {
        int t = cmbTopic.SelectedIndex;
        if (t < 0) return;

        shown = exercises.Where(x => x.Topic == t).ToList();
        cmbExercise.Items.Clear();
        foreach (var ex in shown)
            cmbExercise.Items.Add($"Ex {exercises.IndexOf(ex) + 1}: {ex.Title}");

        lblComplexity.Text = "Complexity Info: " + complexityInfo[t];
        cmbExercise.SelectedIndex = 0;
    }

    private void CmbExercise_SelectedIndexChanged(object? sender, EventArgs e)
    {
        int i = cmbExercise.SelectedIndex;
        if (i < 0) return;
        var ex = shown[i];

        lstOutput.Items.Clear();
        txtInput.Enabled = ex.Kind != InputKind.None;
        txtInput.Text = ex.Kind == InputKind.None ? "N/A" : ex.DefaultInput;
    }

    private void BtnRun_Click(object? sender, EventArgs e)
    {
        int i = cmbExercise.SelectedIndex;
        if (i < 0) return;
        var ex = shown[i];

        string input = txtInput.Text.Trim();
        int number = 0;

        if (ex.Kind == InputKind.Number &&
            (!int.TryParse(input, out number) || number < ex.Min || number > ex.Max))
        {
            MessageBox.Show($"Please enter a whole number from {ex.Min:N0} to {ex.Max:N0}.",
                            "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtInput.Focus();
            txtInput.SelectAll();
            return;
        }
        if (ex.Kind == InputKind.Text && input.Length == 0)
        {
            MessageBox.Show("Please type a name to search for.",
                            "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtInput.Focus();
            return;
        }

        lstOutput.BeginUpdate();
        lstOutput.Items.Clear();
        lstOutput.Items.Add($"--- Exercise {exercises.IndexOf(ex) + 1}: {ex.Title} ---");
        foreach (string line in ex.Run(input, number))
            lstOutput.Items.Add(line);
        lstOutput.EndUpdate();
    }

    private void AddEx(int topic, string title, InputKind kind, string defaultInput, int min, int max,
                       Func<string, int, List<string>> run)
        => exercises.Add(new Exercise(topic, title, kind, defaultInput, min, max, run));

    private static string ArrayText(int[] a) =>
        a.Length <= 20
            ? "[" + string.Join(", ", a) + "]"
            : $"[{a[0]}, {a[1]}, {a[2]}, ... , {a[^1]}] ({a.Length} items)";

    private static void Choose(int n, string result, List<string> output)
    {
        if (n == 0)
        {
            output.Add(result);
            return;
        }
        Choose(n - 1, result + "A", output);
        Choose(n - 1, result + "B", output);
    }

    private void BuildExercises()
    {
        // Exercise 1: Array Index Access
        AddEx(0, "Array Index Access", InputKind.None, "", 0, 0, (_, _) =>
        {
            var o = new List<string>();
            int[] numbers = { 10, 20, 30, 40, 50 };
            o.Add($"Array: {ArrayText(numbers)}");
            o.Add("Accessing index [2] directly...");
            int answer = numbers[2];
            o.Add($"Result: {answer}");
            o.Add("");
            o.Add("Steps taken: 1 (same for any array size)");
            return o;
        });

        // Exercise 2: Addition of Two Numbers
        AddEx(0, "Addition of Two Numbers", InputKind.None, "", 0, 0, (_, _) =>
        {
            var o = new List<string>();
            int a = 5, b = 7;
            o.Add($"a = {a}, b = {b}");
            o.Add("Adding a + b...");
            int sum = a + b;
            o.Add($"Result: {sum}");
            o.Add("");
            o.Add("Steps taken: 1");
            return o;
        });

        // Exercise 3: Access First Item in Array
        AddEx(0, "Access First Item in Array", InputKind.None, "", 0, 0, (_, _) =>
        {
            var o = new List<string>();
            string[] fruits = { "Apple", "Banana", "Mango" };
            o.Add($"Array: [{string.Join(", ", fruits)}]");
            o.Add("Accessing index [0] (the first item)...");
            string fruit = fruits[0];
            o.Add($"Result: {fruit}");
            o.Add("");
            o.Add("Steps taken: 1 (same for any array size)");
            return o;
        });

        // Exercise 4: Loop and Print Array Elements 
        AddEx(1, "Loop and Print Array Elements", InputKind.Number, "5", 1, 100, (_, n) =>
        {
            var o = new List<string>();
            int[] numbers = Enumerable.Range(1, n).ToArray();
            o.Add($"Array: {ArrayText(numbers)}");
            int steps = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                steps++;
                o.Add($"Step {steps}: printing {numbers[i]}");
            }
            o.Add("");
            o.Add($"{numbers.Length} items = {steps} steps.");
            return o;
        });

        // Exercise 5: Linear Search for a Name 
        AddEx(1, "Linear Search for a Name", InputKind.Text, "Carlo", 0, 0, (input, _) =>
        {
            var o = new List<string>();
            string[] names = { "Ana", "Ben", "Carlo", "Dina" };
            o.Add($"Array: [{string.Join(", ", names)}]");
            o.Add($"Searching for \"{input}\"...");
            int checks = 0;
            bool found = false;
            foreach (string name in names)
            {
                checks++;
                o.Add($"Check {checks}: {name}");
                if (name == input)
                {
                    found = true;
                    o.Add($"Found {input}!");
                }
            }
            o.Add("");
            if (!found) o.Add($"\"{input}\" was not found (spelling must match exactly).");
            o.Add($"Checked {checks} names. More names = more checks.");
            return o;
        });

        // Exercise 6: Sum Array Elements
        AddEx(1, "Sum Array Elements", InputKind.Number, "5", 1, 100, (_, n) =>
        {
            var o = new List<string>();
            int[] numbers = Enumerable.Range(1, n).ToArray();
            o.Add($"Array: {ArrayText(numbers)}");
            int total = 0;
            foreach (int value in numbers)
            {
                total += value;
                o.Add($"Added {value}, total is now {total}");
            }
            o.Add("");
            o.Add($"Result: {total}");
            o.Add($"{numbers.Length} items = {numbers.Length} steps.");
            return o;
        });

        // Exercise 7: Binary Search Algorithm 
        AddEx(2, "Binary Search Algorithm", InputKind.Number, "23", 1, 100, (_, target) =>
        {
            var o = new List<string>();
            int[] numbers = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            o.Add($"Sorted array: {ArrayText(numbers)}");
            o.Add($"Looking for {target}...");
            int left = 0, right = numbers.Length - 1, steps = 0;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                steps++;
                o.Add($"Step {steps}: left={left}, right={right}, middle={middle} (value {numbers[middle]})");
                if (numbers[middle] == target)
                {
                    o.Add("");
                    o.Add($"Found {target} at index {middle} in {steps} steps.");
                    return o;
                }
                else if (numbers[middle] < target) left = middle + 1;
                else right = middle - 1;
            }
            o.Add("");
            o.Add($"{target} is not in the array. Checked in {steps} steps.");
            return o;
        });

        // Exercise 8: Halving Loop
        AddEx(2, "Halving Loop", InputKind.Number, "64", 1, 1000000, (_, start) =>
        {
            var o = new List<string>();
            int n = start, steps = 0;
            o.Add($"Start: n = {n:N0}");
            while (n > 1)
            {
                n = n / 2;
                steps++;
                o.Add($"Step {steps}: n = {n:N0}");
            }
            o.Add("");
            o.Add($"Only {steps} steps to go from {start:N0} down to 1.");
            return o;
        });

        // Exercise 9: Binary Search Guessing Range
        AddEx(2, "Binary Search Guessing Range", InputKind.Number, "73", 1, 100, (_, secret) =>
        {
            var o = new List<string>();
            o.Add($"Secret number is {secret} (range 1 to 100)");
            int low = 1, high = 100, tries = 0;
            while (low <= high)
            {
                int guess = (low + high) / 2;
                tries++;
                string hint = guess == secret ? "Correct!" : guess < secret ? "Too low, go higher" : "Too high, go lower";
                o.Add($"Guess {tries}: {guess} (low={low}, high={high}) -> {hint}");
                if (guess == secret) break;
                if (guess < secret) low = guess + 1;
                else high = guess - 1;
            }
            o.Add("");
            o.Add($"Got it in {tries} guesses out of 100 possible numbers.");
            return o;
        });

        // Exercise 10: Array Pair Combinations
        AddEx(3, "Array Pair Combinations", InputKind.Number, "4", 1, 20, (_, n) =>
        {
            var o = new List<string>();
            int[] numbers = Enumerable.Range(1, n).ToArray();
            o.Add($"Array: {ArrayText(numbers)}");
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
                for (int j = 0; j < numbers.Length; j++)
                {
                    count++;
                    o.Add($"Pair {count}: ({numbers[i]}, {numbers[j]})");
                }
            o.Add("");
            o.Add($"{numbers.Length} items x {numbers.Length} items = {count} pairs.");
            return o;
        });

        // Exercise 11: Multiplication Table
        AddEx(3, "Multiplication Table", InputKind.Number, "5", 1, 12, (_, n) =>
        {
            var o = new List<string>();
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                string row = "";
                for (int j = 1; j <= n; j++)
                {
                    count++;
                    row += (i * j).ToString().PadLeft(4);
                }
                o.Add(row);
            }
            o.Add("");
            o.Add($"{n} x {n} = {count} steps.");
            return o;
        });

        // Exercise 12: Nested Loop Step Counter
        AddEx(3, "Nested Loop Step Counter", InputKind.Number, "6", 1, 1000, (_, n) =>
        {
            var o = new List<string>();
            long steps = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    steps++;
            o.Add($"n = {n}  ->  {steps:N0} steps");

            int doubled = n * 2;
            long steps2 = 0;
            for (int i = 0; i < doubled; i++)
                for (int j = 0; j < doubled; j++)
                    steps2++;
            o.Add($"n = {doubled}  ->  {steps2:N0} steps (n doubled)");
            o.Add("");
            o.Add("Double n and the steps become 4 times bigger.");
            return o;
        });

        // Exercise 13: Light Switches
        AddEx(4, "Light Switches", InputKind.Number, "5", 1, 30, (_, n) =>
        {
            var o = new List<string>();
            long possibilities = 1;
            o.Add("Start: 0 switches = 1 possibility");
            for (int i = 0; i < n; i++)
            {
                possibilities *= 2;
                o.Add($"Add switch {i + 1}: {possibilities:N0} possibilities");
            }
            o.Add("");
            o.Add($"{n} switches (ON/OFF) = {possibilities:N0} combinations.");
            return o;
        });

        // Exercise 14: Coin Toss
        AddEx(4, "Coin Toss", InputKind.Number, "4", 1, 30, (_, n) =>
        {
            var o = new List<string>();
            long possibilities = 1;
            o.Add("Start: 0 tosses = 1 possible result");
            for (int i = 0; i < n; i++)
            {
                possibilities *= 2;
                o.Add($"After toss {i + 1}: {possibilities:N0} possible results");
            }
            o.Add("");
            o.Add($"{n} tosses (Heads/Tails) = {possibilities:N0} outcomes.");
            return o;
        });

        // Exercise 15: Recursive Combinations
        AddEx(4, "Recursive Combinations", InputKind.Number, "3", 1, 10, (_, n) =>
        {
            var o = new List<string>();
            Choose(n, "", o);
            int count = o.Count;
            o.Add("");
            o.Add($"n = {n} -> {count} combinations (2^{n}). Each extra n doubles it.");
            return o;
        });
    }

    private void lblComplexity_Click(object sender, EventArgs e)
    {

    }
}