public async Task ReadFileDataAsync(string filePath)
{
    try
    {
        using (var reader = new StreamReader(filePath))
        {
            string content = await reader.ReadToEndAsync();
            Console.WriteLine("File content read successfully:");
            Console.WriteLine(content);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
    }
}