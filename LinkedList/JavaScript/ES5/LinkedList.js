

var LinkedList = function(){

    var LinkedListNode = function(value){
        this.value = value;
        this.next = null;
    };
    var _head = null;
    var _tail = null;
    var _length = 0;
    this.length = function(){
        return _length;
    };
    //get
    //O(1)
    this.getHead = function(){
        return _head.value;
    };
    //O(1)
    this.getTail = function(){
        return _tail.value;
    };
    //O(n)
    this.get = function(index){
        var counter =0;
        var cur = _head;
        if(index == 0){
            return cur.value;
        }
        else{
            while(cur != null){
                if(counter == index){
                    return cur.value;
                }
                cur = cur.next;
                counter++;
            }
        }
    };

    //add
    //O(1)
    this.addFirst = function (value) {
        var node = new LinkedListNode(value);
        if(_head == null){
            _head = node;
            node.next = null;
            _tail = node;
        }
        else{
            node.next = _head;
            _head = node;
        }
        _length++;
    };
    //O(1)
    this.addLast= function () {
        var node = new LinkedListNode(value);
        if(_tail == null){
            _head = node;
            node.next = null;
            _tail = node;
        }
        else{
            _tail.next = node;
            _tail = node;
        }
        _length++;
    };
    //O(n)
    this.add = function(value, index){
        var node = new LinkedListNode(value);
        var counter =0;
        var cur = _head;
        var pre = _head;
        if(_head == null && index == 0){
            _head = node;
            node.next = null;
            _tail = node;
            _length++;
        }
        else{
            while(cur != null){
                if(counter == index){
                    pre.next = node;
                    node.next = cur;
                    cur = null;
                    _length++;
                }
                pre = cur;
                cur = cur.next;
                counter++;
            }
        }
    };

    //remove
    //O(1)
    this.removeFirst = function (value) {
        var node = new LinkedListNode(value);
        if(_head == null){
            _head = node;
            node.next = null;
            _tail = node;
            _length--;
        }
        else{
            node.next = _head;
            _head = node;
            _length--;
        }
    };
    //O(1)
    this.removeLast= function () {
        var node = new LinkedListNode(value);
        if(_tail == null){
            _head = node;
            node.next = null;
            _tail = node;
            _length--;
        }
        else{
            _tail.next = node;
            _tail = node;
            _length--;
        }
    };
    //O(n)
    this.remove = function(index){
        var counter =0;
        var cur = _head;
        var pre = _head;
        while(cur != null){
            if(counter == index){
                pre.next = cur.next;
                cur.next = null;
                cur = null;
                _length--;
            }
            pre = cur;
            cur = cur.next;
            counter++;
        }
    };
    this.clear= function () {
        _head = null;
        _tail = null;
        _length = 0;
    };
};




/*
//TEST
//--------------------------------------------
var linkedList = new LinkedList();
for(var i=0 ; i< 10; i++)
{
    linkedList.addFirst("saeed  "+ i);
}

//prent
    for(var i=0 ; i< linkedList.length(); i++)
    {
        console.log(linkedList.get(i));
    }
//--------------------------------------------
*/