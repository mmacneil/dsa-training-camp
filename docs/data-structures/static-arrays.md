# Static Arrays

<hr/>

Arrays are the most simple data structure. We use indexes to access the values inside an array. The first value is always at index 0. Because we can map an array index directly to the value in memory to retrieve it efficiently the operation can be represented in Big O as O(1).

Because it happens in constant time. No matter how big the array gets we can read it instantly. The name RAM (Random Access Memory) comes from the fact that we can randomly access any value in memory in constant time.

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
