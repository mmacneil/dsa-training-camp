# What Is a Data Structure?

<hr/>

Simply put, data structures allow us to structure data inside of the computer's memory (RAM).

Many of today's computers measure their RAM in gigabytes. The prefix giga means 10⁹ in the International System of Units (SI). Therefore, one gigabyte is one billion bytes.

A byte is a unit of digital information that most commonly consists of eight bits. A bit is a position within the byte that can store either 0 or 1.

<img src="https://github.com/mmacneil/dsa-training-camp/blob/main/docs/data-structures/img/ram.png" />

32-bit integer values are represented by 4 bytes (32-bit int "1" = 00000000000000000000000000000001)

When stored contiguously in memory an [array](https://en.wikipedia.org/wiki/Array_data_structure) of integers might look like:

<table>
  <tr>
    <th>VALUE</th>
    <td>1</td>
    <td>3</td>
    <td>5</td>
  </tr>
  <tr>
    <th>ADDRESS</th>
    <td>$0</td>
    <td>$4</td>
    <td>$8</td>
  </tr>
</table>

An array of single-byte ASCII characters might look something like:

<table>
  <tr>
    <th>VALUE</th>
    <td>a</td>
    <td>b</td>
    <td>c</td>
  </tr>
  <tr>
    <th>ADDRESS</th>
    <td>$0</td>
    <td>$1</td>
    <td>$2</td>
  </tr>
</table>

We can store values contiguously in memory no matter how big or small as long as we increment our address by the size of the value.
