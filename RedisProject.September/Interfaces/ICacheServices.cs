namespace RedisProject.September.Interfaces
{
    public interface ICacheServices
    {
        //verile key göre dataları getirir
        Task<string> GetValueAsync(string key);

        //key ve value göre data ekler
        Task<bool> SetValueAsync(string key, string value);

        //data varsa T tipinde döndürüryoksa önce db ekler sonra döndürür-async
        Task<T> GetOrAddAsync<T>(string key, Func<Task<T>> action) where T : class;

        //data varsa T tipinde döndürüryoksa önce db ekler sonra döndürür
        T GetOrAdd<T>(string key, Func<T> action) where T : class;

        //verilen key sahip datayı siler
        Task Clear(string key);

        //tüm db deki datayı siler
        void ClearAll();
    }
}
