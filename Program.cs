using System;
using System.Collections.Generic;

namespace sendOTP
{
    public class CacheItem<T>
    {
        public T Value { get; set; }
        public DateTime Expiration { get; set; }
    }

    public class SimpleCache<T>
    {
        private Dictionary <string, CacheItem<T>> _cache = new(); 

        public void Set(string key, T value, TimeSpan tll )
        {
            var item = new CacheItem<T>
            {
                Value = value,
                Expiration = DateTime.Now.Add(tll)
            };
            _cache.Add(key, item);
        }

        public T Get(string e)
        {
            if (!_cache.ContainsKey(e))
                return default;
            // tinawag ang dictionary na may lamang "E" depende sa lalagay sa parameter sa method
            var item = _cache[e];

            if (item.Expiration != null && item.Expiration < DateTime.Now)
            {
                Console.WriteLine("Expired");
                _cache.Remove(e);
                return default;
            }
            return item.Value;
        }
    }
    public class sendOTP 
    {
        static void Main(string[] args)
        {
            var otp = new SimpleCache<object>();
            otp.Set("OTP", 12345, TimeSpan.FromSeconds(2));

            //Task.Delay(5000).Wait();
            var get = otp.Get("OTP");
            Console.WriteLine(get);
        }
    }
}