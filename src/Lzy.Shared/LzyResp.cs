namespace Lzy.Shared
{
    public class LzyResp
    {
        public LzyHttpCode Code { get; set; } = LzyHttpCode.Success;

        public string? Message { get; set; }
        public object? Data { get; set; }

        public object? OtherData { get; set; }
        public int TotalCount { get; set; } = 0;
    }
}