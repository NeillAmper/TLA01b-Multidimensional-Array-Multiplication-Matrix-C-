using Godot;
using System;

public partial class AmperMatrix : Node
{
	public override void _Ready()
	{
		int[,] matrix = new int[13, 13];

		for (int i = 1; i <= 12; i++)
		{
			for (int e = 1; e <= 12; e++)
			{
				matrix[i, e] = i * e;
			}
		}

		string header = "    ";
		for (int i = 1; i <= 12; i++)
		{
			header += i < 10 ? $"   {i}" : $"  {i}";
		}
		GD.Print(header);

		for (int o = 1; o <= 12; o++)
		{
			string row = o < 10 ? $"   {o}" : $"  {o}";

			for (int a = 1; a <= 12; a++)
			{
				int value = matrix[o, a];
				if (value < 10)
				{
					row += $"   {value}";
				}
				else if (value < 100)
				{
					row += $"  {value}";
				}
				else
				{
					row += $" {value}";
				}
			}
			GD.Print(row);
		}
	}
}
