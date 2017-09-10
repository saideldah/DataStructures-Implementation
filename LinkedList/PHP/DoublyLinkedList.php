<?php
/**
 * Created by PhpStorm.
 * User: saeed
 * Date: 24/11/16
 * Time: 05:16 AM
 */

namespace LinkedList;
require_once "DoublyLinkedListNode.php";

class DoublyLinkedList
{
    private $head = null;
    private $tail = null;
    private $count = 0;

    public function length(){
        return $this->count;
    }
    //Get
    //O(1)
    public function getHead()
    {
        if ($this->head == null)
        {
            return $this->head;
        }
        else
        {
            return $this->head->value;
        }
    }
    //O(1)
    public function getTail()
    {
        if ($this->tail == null)
        {
            return $this->tail;
        }
        else
        {
            return $this->tail->value;
        }
    }
    //O(n)
    public function get($index)
    {
        if ($index < 0 || $index > $this->length()){
            return null;
        }
        else{
            if ($index == 0){
                return $this->getHead();
            }
            else{
                if ($index == $this->length()){
                    return $this->getTail();
                }
                else{
                    $cur = $this->head;
                    $c =0;
                    while ($cur != null){
                        if ($index == $c){
                            return $cur->value;
                        }
                        $c++;
                        $cur = $cur->next;
                    }
                }
            }
        }
    }

    //Add
    //O(1)
    public function addFirst($value)
    {
        if ($this->head == null){
            $node = new DoublyLinkedListNode($value);
            $this->head = $node;
            $this->tail = $node;
        }
        else{
            $node = new DoublyLinkedListNode($value);
            $this->head->previous = $node;
            $node->next = $this->head;
            $this->head = $node;
        }
        $this->count--;
    }
    //O(1)
    public function addLast($value)
    {
        if ($this->tail == null){
            $node = new DoublyLinkedListNode($value);
            $this->head = $node;
            $this->tail = $node;
        }
        else{
            $node = new DoublyLinkedListNode($value);
            $this->tail->next = $node;
            $node->previous = $this->tail;
            $this->tail = $node;
        }
        $this->count++;
    }
    //O(n)
    public function add($value, $index)
    {
        if ($index < 0 || $index > $this->length()){
            // throw new \Exception();
        }
        else{
            if ($index == 0){
                return $this->addFirst($value);
            }
            else{
                if ($index == $this->length()){
                    return $this->addLast($value);
                }
                else{
                    $cur = $this->head;
                    $c =0;
                    while ($cur != null){
                        if ($index == $c){
                            $node = new DoublyLinkedListNode($value);
                            $node->previous = $cur;
                            $node->next = $cur->next;
                            $cur->next->previous = $node;
                            $this->count++;
                        }
                        $c++;
                        $cur = $cur->next;
                    }
                }
            }
        }
    }

    //Get
    //O(1)
    public function removeFirst()
    {
        if ($this->head != null){
            $temp = $this->head;
            $this->head = $this->head->next;
            $temp->next =  null;
            $this->head->previous = null;
            $this->count--;
        }
    }
    //O(1)
    public function removeLast()
    {
        if ($this->tail != null){
            $temp = $this->tail;
            $this->tail = $this->tail->previous;
            $temp->next =  null;
            $this->tail->next = null;
            $this->count--;
        }
    }
    //O(n)
    public function remove($index)
    {
        if ($index < 0 || $index > $this->length()){
            // throw new \Exception();
        }
        else{
            if ($index == 0){
                return $this->removeFirst();
            }
            else{
                if ($index == $this->length()){
                    return $this->removeLast();
                }
                else{
                    $cur = $this->head;
                    $c =0;
                    while ($cur != null){
                        if ($index == $c){
                            $cur = $cur->next;
                            $cur->previous->next = $cur->next;
                            $cur->next->previous = $cur->previous;
                            $cur = null;
                            $this->count--;
                        }
                        $c++;
                        $cur = $cur->next;
                    }
                }
            }
        }
    }
    //O(1)
    public function clear()
    {
        $this->tail = null;
        $this->head = null;
    }
}