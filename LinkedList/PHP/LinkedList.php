<?php

class LinkedListNode{
    public $value = null;
    public $next = null;

    public function __construct($value)
    {
        $this->value = $value;
    }
}

class LinkedList {
    private $head = null;
    private $tail = null;

    private $length = 0;

    //Get
    //O(1)
    public function getHead(){
       return $this->head;
    }
    //O(1)
    public function getTail(){
        return $this->tail;
    }
    //O(1)
    public function get($index){
        if (is_null($this->head)){
            return $this->head;
        }
        else{
            $cur = $this.$this->head;
            $counter = 0;
            while (!is_null($cur)){
                if ($counter == $index){
                    return $cur;
                }
                $cur = $cur->next;
                $counter ++;
            }
        }
    }

    //Add
    public function addFirst($var){
        $node = new LinkedListNode($var);
        if(is_null($this->head)){
            $this->head = $node;
            $this->tail = $node;
        }
        else{
            $node->next = $this->head;
            $this->head = $node;
        }
    }
    public function addLast($var){

        $node = new LinkedListNode($var);
        if(is_null($this->head)){
            $this->head = $node;
            $this->tail = $node;
        }
        else{
            $this->tail->next = $node;
            $this->tail = $node;
        }
    }
    public function add($index){

    }

    //Remove

}
?>