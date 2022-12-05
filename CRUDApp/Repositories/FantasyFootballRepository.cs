using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class FantasyFootballRepository
    {
        private FantasySportsContext _dbContext;

        public FantasyFootballRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Points(int playerGuess, int weeklyScore)
        {
            int points = 0;

            if (playerGuess == weeklyScore + 14)
            {
                points += 1;
            }
            if (playerGuess == weeklyScore + 13)
            {
                points += 1;
            }
            if (playerGuess == weeklyScore + 12)
            {
                points += 1;
            }
            if (playerGuess == weeklyScore + 11)
            {
                points += 1;
            }
            if (playerGuess == weeklyScore + 10)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore + 9)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore + 8)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore + 7)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore + 6)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore + 5)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore + 4)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore + 3)
            {
                points += 5;
            }
            if (playerGuess == weeklyScore + 2)
            {
                points += 5;
            }
            if (playerGuess == weeklyScore + 1)
            {
                points += 5;
            }
            if (playerGuess == weeklyScore)
            {
                points += 5;
            }
            if (playerGuess == weeklyScore - 1)
            {
                points += 5;
            }
            if (playerGuess == weeklyScore - 2)
            {
                points += 5;
            }
            if (playerGuess == weeklyScore - 3)
            {
                points += 5;
            }
            if (playerGuess == weeklyScore - 4)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore - 5)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore - 6)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore - 7)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore - 8)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore - 9)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore - 10)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore - 11)
            {
                points += 1;
            }
            if (playerGuess == weeklyScore - 12)
            {
                points += 1;
            }
            if (playerGuess == weeklyScore - 13)
            {
                points += 1;
            }
            if (playerGuess == weeklyScore - 14)
            {
                points += 1;
            }
            return points;
        }
    }
}
