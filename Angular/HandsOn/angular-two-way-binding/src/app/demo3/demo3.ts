import { Component } from '@angular/core';
import { Book } from '../book';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-demo3',
  imports: [FormsModule, CommonModule],
  templateUrl: './demo3.html',
  styleUrl: './demo3.css',
})
export class Demo3 {
  isAvalable: boolean = false;
  book: Book;
  books: Book[] = []; //empty array
  constructor() {
    this.book = {
      id: 0,
      name: '',
      price: 0,
      author: ''

    }
  }
  addBook() {
    this.book.id = (Math.floor(Math.random() * 1000))
    //add book to the array
    console.log(this.book)
    this.books.push(this.book);
    console.log(this.books);
    //reset book data
    this.book = {
      id: 0,
      name: '',
      price: 0,
      author: ''

    }
    if (this.books.length > 0)
      this.isAvalable = true;
  }
}
