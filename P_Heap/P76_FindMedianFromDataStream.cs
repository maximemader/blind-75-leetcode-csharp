namespace Blind75LeetCode;

/// <summary>
/// Find Median From Data Stream
/// https://leetcode.com/problems/find-median-from-data-stream/
/// </summary>
public class P76_FindMedianFromDataStream
{
    private readonly PriorityQueue<int, int> _maxHeap = new ();
    private readonly PriorityQueue<int, int> _minHeap = new ();
    private bool _isEven = true;
    
    public P76_FindMedianFromDataStream() 
    {
        
    }
    
    public void AddNum(int num) 
    {
        _isEven = !_isEven;
        
        if(_maxHeap.Count == 0 || _maxHeap.Peek() <= num)
        {
            _maxHeap.Enqueue(num, num);
        } 
        else 
        {
            _minHeap.Enqueue(num, -num);
        }

        if(_maxHeap.Count - _minHeap.Count > 1)
        {
            var value = _maxHeap.Dequeue();

            _minHeap.Enqueue(value, -value);
        }
        else if(_minHeap.Count > _maxHeap.Count)
        {
            var value = _minHeap.Dequeue();

            _maxHeap.Enqueue(value, value);
        }
    }
    
    public double FindMedian()
    {
        if(_minHeap.Count == 0)
            return _maxHeap.Count == 0 ? 0.0: _maxHeap.Peek();
        
        return _isEven
            ? (_minHeap.Peek() + _maxHeap.Peek()) / 2.0
            : _maxHeap.Peek();
    }
}