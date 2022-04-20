using telesoftas_assignment;

//Enter Texts
Console.WriteLine("Please enter texts to be wrapped");

//Read Texts
string InputText = Console.ReadLine().ToString();

//Enter Maximum Number of characters per Line
Console.WriteLine("Please enter Maximum Number of characters per Line");

//Read Maximum Number
var InputNumber = Console.ReadLine();
int LineLength;
Int32.TryParse(InputNumber, out LineLength);

//Write Input Text to Input.txt file
if (InputText != null || InputText != string.Empty)
    File.WriteAllText(FileService.TextFile, InputText);

//Read Input Text from Input.txt file
string ReadText = File.ReadAllText(FileService.TextFile);

//Call the WrapText Function in FileService
string OutputText = FileService.WrapText(ReadText, LineLength);

//Write the Wrapped Text into the output.txt file
File.WriteAllText(FileService.WrappedTextFile, OutputText);

Console.WriteLine("Congratulations ! your texts has been wrapped \nReview output.txt file to see your wrapped texts");

