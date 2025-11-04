# 🧮 Simple Calculator Application (C# - Windows Forms)

This project is a simple desktop calculator application developed using the C# programming language and Windows Forms, capable of performing the four basic arithmetic operations (addition, subtraction, multiplication, division).

## ✨ Features

  * **Four Basic Arithmetic Operations:** Addition (`+`), Subtraction (`-`), Multiplication (`*`), Division (`/`).
  * **User Input:** Easy number entry using number buttons (`0` - `9`).
  * **Decimal Number Support:** Enter decimal numbers using the comma (`,`) button.
  * **Negative Number Support:** Change the sign of a number using the `+/-` button.
  * **Clear Screen:** Reset the screen and memory with the `C` button.
  * **Undo:** Delete the last entered character with the `<--` (Backspace) button.
  * **Calculate Result:** Perform the selected operation with the `=` button.

## 🛠️ Setup and Execution

### Requirements

  * [**Visual Studio**](https://visualstudio.microsoft.com/tr/downloads/) (Preferably 2017 or later)
  * **.NET Framework** (The version targeted by the project)
  * 

### Steps

1.  Download or copy the files for this project to your computer.
2.  Open Visual Studio and open the project (**.sln** file).
3.  Once the project is compiled, run the application by pressing the **Start** button (`F5` key) in Visual Studio.

## 📁 Project Structure

The project basically consists of the following C# files:

  * **`Form1.cs`**: The application's **back-end code** (Code-Behind) is located in this file. The logic for all mathematical operations and button click events is defined here.
      * Variables for number and operation selection (`sayi1`, `sayi2`, `secim`, `sonuc`) are defined.
      * The `Buttonlar()` method is for number buttons, special methods (`toplamabtn_Click`, `cikarmabtn_Click`, etc.) are for operator buttons, and the `esittirbtn_Click` method calculates the result.
  * **`Form1.Designer.cs`**: Contains the **design code** for the Windows Forms interface. All buttons in the application and the `TextBox` control named `txtDisplay` are defined and placed here.
  * **`Form1.resx`**: An XML-based file containing the application's language and resource files.

## 💡 Key Points in the Code

### Operation Selection and Calculation (`Form1.cs`)

The operation selection is managed using an integer variable (`selection`):

  * **Addition:** `selection = 1`
  * **Subtraction:** `selection = 2`
  * **Multiplication:** `selection = 3`
  * **Division:** `selection = 4`
  * 

During the calculation (`esittirbtn_Click` method), this `selection` variable is checked:

```csharp
// Example: Equal button method
private void esittirbtn_Click(object sender, EventArgs e)
{
    number2 = double.Parse(txtDisplay.Text);
    
    // Each if block calculates the result based on the operation type and writes it to the screen
    if (selection == 1)
    {
        result = number1 + number2;
    }
    txtDisplay.Text = result.ToString();
    // ... the same structure repeats for other operations ...
}
```

> **Development Note:** The `if` blocks in the `esittirbtn_Click` method and the line `txtDisplay.Text = sonuc.ToString();` display the result of the last calculated operation (Division) because they print the result after each operation is calculated. This is the current behavior of the application and can be made cleaner by converting it to a single `if/else if` structure.

### Negative Number Operation

The negative button (`btnNegatif`) checks whether the number has a minus (`-`) sign at the beginning:

```csharp
private void btnNegatif_Click(object sender, EventArgs e)
{
    if (txtDisplay.Text != “0”)
    {
        if (txtDisplay.Text.StartsWith(“-”))
        {
    txtDisplay.Text = txtDisplay.Text.Replace(“-”, “”); // Remove the minus sign if present
}
else // Add the minus sign if not present
{
    txtDisplay.Text = “-” + txtDisplay.Text;
}
```

## ✒️ Contributor

  * Yusuf Can Ozan

-----
