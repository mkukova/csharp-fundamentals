﻿using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _1.WinningTicket
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] inputTickets = Console.ReadLine()
				.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

			Dictionary<string, string> ticketWithPrize = new Dictionary<string, string>();

			foreach (string ticket in inputTickets)
			{
				if (ticket.Length != 20)
				{
					ticketWithPrize.Add(ticket, "invalid");
				}
				else
				{
					string firstHalf = ticket.Substring(0, 10);
					string secondHalf = ticket.Substring(10, 10);

					Regex jackpotRegex = new Regex(@"[@]{10}|[#]{10}|[$]{10}|[\^]{10}");
					Match firstHalfJackpotMatch = jackpotRegex.Match(firstHalf);
					Match secondHalfJackpotMatch = jackpotRegex.Match(secondHalf);

					string firstHalfJackpot = firstHalfJackpotMatch.ToString();
					string secondHalfJackpot = secondHalfJackpotMatch.ToString();

					if ((firstHalfJackpotMatch.Success && secondHalfJackpotMatch.Success) && firstHalfJackpot.Equals(secondHalfJackpot))
					{
						char winningSymbol = firstHalfJackpot[0];
						ticketWithPrize.Add(ticket, $"10{winningSymbol} Jackpot!");
					}
					else
					{
						Regex winnerPattern = new Regex(@"[@]{6,9}|[#]{6,9}|[$]{6,9}|[\^]{6,9}");
						Match firstHalfWinnerMatch = winnerPattern.Match(firstHalf);
						Match secondHalfWinnerMatch = winnerPattern.Match(secondHalf);
						string firstHalfWinner = firstHalfWinnerMatch.ToString();
						string secondHalfWinner = secondHalfWinnerMatch.ToString();

						if ((firstHalfWinnerMatch.Success && secondHalfWinnerMatch.Success) && firstHalfWinner[0].Equals(secondHalfWinner[0]))
						{
							int prizeSize = Math.Min(firstHalfWinner.Length, secondHalfWinner.Length);
							char winningSymbol = firstHalfWinner[0];
							ticketWithPrize.Add(ticket, $"{prizeSize}{winningSymbol}");
						}
						else
						{
							ticketWithPrize.Add(ticket, "no match");
						}
					}
				}
			}

			foreach (var ticket in ticketWithPrize)
			{
				if (ticket.Value.Equals("invalid"))
				{
					Console.WriteLine("invalid ticket");
				}
				else
				{
					Console.WriteLine($"ticket \"{ticket.Key}\" - {ticket.Value}");
				}
			}
		}
	}
}
