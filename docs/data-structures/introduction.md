# What is a Data Structure?

Simply put, data structures allow us to structure data inside of the computer's memory (RAM).

The majority of today's computers measure their RAM in gigabytes. The prefix giga means 10⁹ in the International System of Units (SI). Therefore, one gigabyte is one billion bytes.

A byte is a unit of digital information that most commonly consists of eight bits. A bit is position within the byte that can store either 0 or 1.

Common for integer values to be represented by 4 bytes (32-bit int = 0...1)

When store contiguously in memory an array of integers might look like:

|--------------------------------------------|
| VALUE: 1 | 3 | 5 |
| ADDRESS: $0 | $4 | $8 |
|--------------------------------------------|

An array of single-byte ASCII characters might look something like:

|--------------------------------------------|
| VALUE: a | b | c |
| ADDRESS: $0 | $1 | $2 |
|--------------------------------------------|

We can store values contiguously in memory no matter how big or small as long as we increment our address by the size of the value.

Arrays are the most simple data structure.
