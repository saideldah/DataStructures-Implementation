<?php
/**
 * Created by PhpStorm.
 * User: saeed
 * Date: 24/11/16
 * Time: 05:18 AM
 */

namespace LinkedList;


class DoublyLinkedListNode
{
    public $value;
    public $next;
    public $previous;

    public function __construct($value)
    {
        $this->previous = null;
        $this->next = null;
        $this->value = $value;
    }
}