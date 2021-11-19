# Leetcode Questions in C#

This repository contains the implementation of the most common data structures in C# and solutions to some questions from Leetcode.

## Overview

The repository consist of a class library of data structures and Leetcode solutions and a unit testing project.

Inside the class library you will find a folder for each data structure folder, inside each of this there are the implementation classes and a folder containing solutions to LeetCodeQuestions.

You can see a working implementation and it's separated into folders so you can write your own 

## Current topics covered

- [x] Singly Linked List Class
  - [ ] Q206 Reverse Linked List
  - [ ] Next question TBC
- [ ] Next topic 'Trees'
- [ ] Next topic TBC



## Write your own implementation!

You can code your own class as long as it implements the Interface for that data structure and run the test!

### Linked List

Write your own of Singly Linked List by 

1. Creating a class inside DataStructures/LinkedList/Implementations/[YOURCLASS.CS]
2. Changing where 'SinglyLinkedList' inherits from

And that's it! now if you also want to write your own implementation for the Leetcode questions then:

1. Create a class inside DataStructures/LinkedList/Questions/[CHOOSE ]/Implementations/ [YOURSOLUTION.CS]
2. Changing where the class containing the solution inherits from e.g for example for Q206-ReverseLinkedList/ folder there is a 'ReverseLinkedList.cs' class that inherits 'SolutionImplementation1'. Change the 'ReverseLinkedList.cs' to point to YOURSOLUTION.CS

## Unit tests

Tests written in NUnit to cover the class implementation of the data structure and the tests for the solutions of the questions.