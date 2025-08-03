public async Task ReadFileDataAsync(string filePath)
{
    try
    {
        using (var reader = new StreamReader(filePath))
        {
            string content = await reader.ReadToEndAsync(); //ensures the file is read asynchronously until the end of the file
            Console.WriteLine("File content read successfully:");
            Console.WriteLine(content); // Display the content of the file after read to end of file is completed
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
    }
}