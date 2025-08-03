public async Task GetDataAsync()
{
    var data = await GetDataFromApi();
    Console.WriteLine(data);
}