using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CommonLibrary.Dto
{
    public class ApiResponse<T>
    {
        public T Data { get; set; }
        public List<string> Errors { get; set; }
        [JsonIgnore]
        public int StatusCode { get; set; }

        public static ApiResponse<T> Success(int StatusCode, T Data)
        {
            return new ApiResponse<T> { StatusCode = StatusCode, Data = Data };
        }

        public static ApiResponse<T> Success(int StatusCode)
        {
            return new ApiResponse<T> { StatusCode = StatusCode };
        }

        public static ApiResponse<T> Fail(int StatusCode, T Data)
        {
            return new ApiResponse<T> { StatusCode = StatusCode, Data = Data };
        }

        public static ApiResponse<T> Fail(int StatusCode, List<string> errors)
        {
            return new ApiResponse<T> { StatusCode = StatusCode, Errors = errors };
        }

        public static ApiResponse<T> Fail(int StatusCode, String errors)
        {
            return new ApiResponse<T> { StatusCode = StatusCode, Errors = new List<String> { errors } };
        }

    }
}
