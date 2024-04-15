// See https://aka.ms/new-console-template for more information
using Accumulate;

Console.WriteLine("Hello, World!");
var counter = 0;
var accumulation = new[]{1,2,3};

var result = accumulation.Accumulate(x => x * counter++);

var obj = result;