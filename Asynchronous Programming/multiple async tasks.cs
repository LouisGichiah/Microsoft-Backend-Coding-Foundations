public async Task GetDataFromMultipleSourcesAsync()
{
    try
    {
        var task1 = GetDataFromApi("https://api.example.com/data1");
        var task2 = GetDataFromApi("https://api.example.com/data2");
        var task3 = GetDataFromApi("https://api.example.com/data3");

        // Wait for all tasks to complete
        await Task.WhenAll(task1, task2, task3);

        // Process results
        Console.WriteLine("Data from source 1: " + await task1);
        Console.WriteLine("Data from source 2: " + await task2);
        Console.WriteLine("Data from source 3: " + await task3);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred while retrieving data: {ex.Message}");
    }
}