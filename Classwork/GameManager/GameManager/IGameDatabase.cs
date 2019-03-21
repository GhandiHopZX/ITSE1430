using System.Collections.Generic;

namespace GameManager
{
    /// <summary>Defines a game database.</summary>
    public interface IGameDatabase
    {
        /// <summary>Adds a new game.</summary>
        /// <param name="game">The game to add.</param>
        /// <returns>The new game.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="game"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="game"/> is invalid.</exception>
        Game Add( Game game );
        
        void Delete( int id );

        /// <summary>Gets a game.</summary>
        /// <param name="id">The ID of the game.</param>
        /// <returns>The updated game.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="game"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to 0.</exception>
        /// <exception cref="ArgumentException">The game does not exist.</exception>
        Game Get( int id );
        
        /// <summary>Gets all games.</summary>
        /// <returns>The list of games.</returns>
        IEnumerable<Game> GetAll();

        /// <summary>Updates an existing game.</summary>
        /// <param name="id">The ID of the existing game.</param>
        /// <param name="game">The game to add.</param>
        /// <returns>The updated game.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="game"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to 0.</exception>
        /// <exception cref="ArgumentException">The game does not exist.</exception>
        /// <exception cref="ValidationException"><paramref name="game"/> is invalid.</exception>
        Game Update( int id, Game game );
    }
}