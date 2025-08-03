try
{
    var data = await GetDataFromApi();
}
catch (Exception ex)
{
    Console.WriteLine($"Failed to fetch data from Api: {ex.Message}");
}