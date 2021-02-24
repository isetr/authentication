using System;

namespace AuthenticationDemo.Models
{
    public record TokenDetails
    (
        string Token,
        DateTime Expiration
    );
}