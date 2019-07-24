﻿namespace WebApplication.Models
{
    public sealed class Response<TReturn> : Response
    {
        public TReturn Object { get; set; }
    }
}