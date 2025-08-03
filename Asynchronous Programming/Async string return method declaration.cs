public async Task<string> GetDataFromApi()
{
    var data = await FetchDataFromApi();
    return data;
}