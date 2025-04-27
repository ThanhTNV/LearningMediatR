using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using ECommerce_v2.Domain.Entity; // Assuming User entity is relevant

namespace ECommerce_v2.Domain.Interface.Service
{
    /// <summary>
    /// Defines the contract for a service that handles JWT generation, validation, and claims extraction.
    /// </summary>
    public interface IJwtService
    {
        /// <summary>
        /// Generates a new access token for the specified user with associated roles.
        /// </summary>
        /// <param name="user">The user for whom the access token is generated.</param>
        /// <param name="roles">The list of roles to include as claims in the access token.</param>
        /// <returns>A string representing the generated access token.</returns>
        string GenerateAccessToken(Customer user, IList<string> roles);

        /// <summary>
        /// Generates a new refresh token for the specified user.
        /// </summary>
        /// <param name="user">The user for whom the refresh token is generated.</param>
        /// <returns>A string representing the generated refresh token.</returns>
        string GenerateRefreshToken(Customer user);

        /// <summary>
        /// Validates a JWT string.
        /// </summary>
        /// <param name="token">The JWT string to validate.</param>
        /// <returns>True if the token is valid, false otherwise.</returns>
        bool ValidateToken(string token);

        /// <summary>
        /// Extracts the ClaimsPrincipal from a valid JWT string.
        /// </summary>
        /// <param name="token">The valid JWT string.</param>
        /// <returns>A ClaimsPrincipal containing the claims from the token.</returns>
        /// <exception cref="ArgumentException">Thrown if the token is null or empty.</exception>
        /// <exception cref="System.IdentityModel.Tokens.SecurityTokenException">Thrown if the token is invalid or cannot be processed.</exception>
        ClaimsPrincipal GetPrincipalFromToken(string token);

        /// <summary>
        /// Optionally, validate and get the principal from a refresh token.
        /// This can be useful for refresh token rotation or validation during token refresh.
        /// </summary>
        /// <param name="refreshToken">The refresh token string to validate and extract principal from.</param>
        /// <returns>A ClaimsPrincipal if the refresh token is valid, otherwise null.</returns>
        ClaimsPrincipal GetPrincipalFromRefreshToken(string refreshToken);
    }
}