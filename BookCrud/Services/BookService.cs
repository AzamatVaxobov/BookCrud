﻿using BookCrud.Models;

namespace BookCrud.Services;

public class BookService
{
    private List<Book> books;


    public BookService()
    {
        books = new List<Book>();
    }

    public Book GetExpensiveBook()
    {
        if (books == null || books.Count == 0)
        {
            return null;
        }
        Book expensiveBook = books[0];
        foreach (var book in books)
        {
            if (expensiveBook.Price < book.Price)
            {
                expensiveBook = book;
            }
        }

        return expensiveBook;
    }

    public Book GetMostPagedBook()
    {
        if (books == null || books.Count == 0)
        {
            return null;
        }
        var mostPagedBook = books[0];
        foreach (var book in books)
        {
            if (mostPagedBook.PageNumber < book.PageNumber)
            {
                mostPagedBook = book;
            }
        }

        return mostPagedBook;
    }

    public Book GetMostReadBook()
    {
        if (books == null || books.Count == 0)
        {
            return null;
        }

        var mostReadBook = new Book();
        int maxReaders = 0;

        foreach (var book in books)
        {
            if (book.ReadersName.Count > maxReaders)
            {
                maxReaders = book.ReadersName.Count;
                mostReadBook = book;
            }
        }

        return mostReadBook;
    }

    public Book GetBookByReaderName(string readerName)
    {
        if (books == null || books.Count == 0)
        {
            return null;
        }

        foreach (var book in books)
        {
            foreach (var reader in book.ReadersName)
            {
                if (reader == readerName)
                {
                    return book;
                }
            }
        }

        return null;
    }

    public Book GetBookByAuthorName(string authorName)
    {
        if (books == null || books.Count == 0)
        {
            return null;
        }

        foreach (var book in books)
        {
            foreach (var author in book.AuthorsName)
            {
                if (author == authorName)
                {
                    return book;
                }
            }
        }

        return null;
    }

    public bool AddReaderToBook(Guid bookId, string readerName)
    {
        foreach (var book in books)
        {
            if (bookId == book.Id)
            {
                book.ReadersName.Add(readerName);

                return true;
            }
        }

        return false;
    }


    public bool AddAuthorToBook(Guid bookId, string authorName)
    {
        foreach (var book in books)
        {
            if (bookId == book.Id)
            {
                book.AuthorsName.Add(authorName);

                return true;
            }
        }

        return false;
    }

}
