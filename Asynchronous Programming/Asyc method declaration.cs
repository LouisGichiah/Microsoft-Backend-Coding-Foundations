public asyc Task GetDataAsync()
{
    var data = await GetDataFromApi();
    Console.WriteLine(data);
}