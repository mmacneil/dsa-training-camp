# What is a Data Structure?

<hr/>

Simply put, data structures allow us to structure data inside of the computer's memory (RAM).

The majority of today's personal computers measure their RAM in gigabytes. The prefix giga means 10⁹ in the International System of Units (SI). Therefore, one gigabyte is one billion bytes.

A byte is a unit of digital information that most commonly consists of eight bits. A bit is a position within the byte that can store either 0 or 1.

32-bit integer values are represented by 4 bytes (32-bit int "1" = 00000000000000000000000000000001)

When stored contiguously in memory an array of integers might look like:

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

## Arrays

Arrays are the most simple data structure. We use indexes to access the values inside an array. The first value is always at index 0. Because we can map an array index directly to the value in memory to retrieve it efficiently the operation can represented in Big O as O(1) - because it happens in constant time. No matter how big the array gets we can read it instantly. The name RAM (Random Access Memory) comes from the fact that we can randomly access any value in memory in constant time.

Static arrays are of fixed size, we can't add new values to them. Some languages, i.e. Python and JavaScript don't use static arrays - they offer Dynamic Arrays as the default. Writing to or removing from an array of any position is also an O(1) operation - constant time.

To insert an element in the middle of an array, we might have to shift every value - in the worst case this is an O(n) operation.

<table>
<thead>
<tr>
<th>Operation</th>
<th>Big-O Time</th>
</tr>
</thead>
<tbody>
<tr>
<td>r/w "i-th" element</td>
<td>O(1) Constant time</td>
</tr>
<tr>
<td>Insert or remove at end</td>
<td>O(1) Constant time</td>
</tr>
<tr>
<td>Insert middle</td>
<td>O(n) Worst case -> Might have to shift every value</td>
</tr>
<tr>
<td>Remove middle</td>
<td>O(n) Worst case -> Might have to shift every value</td>
</tr>
</tbody>
</table>
