# Challenge: Jukebox Class Relationships

---

## Goal

Identify opportunities between the classes to implement things like inheritance, interfaces, aggregation, and or composition. And then modify the class diagrams with the appropriate UML markings to indicate those class relationships.

---

## Exercise

```text
+-----------------------------+     +-----------------------------+     +-----------------------------+
|             User            |     |            Queue            |     |           Library           |
+-----------------------------+     +-----------------------------+     |-----------------------------|
| - id: String                |     | - playlist: Songs[0..*]     |     | - titles: String[1..*]      |
|-----------------------------|     |-----------------------------|     | - albums: Albums[1..*]      |
| + getId(): String           |     | + addSong(Song, String)     |     |-----------------------------|
+-----------------------------+     | + getNextSong(): Song       |     | + getTitles(): String[1..*] |
               △                    | + removeSong(Song)          |     | + getAlbum(String): Album   |
               |                    +-----------------------------+     +-----------------------------+
               |                                  △                                    △               |                                  |                                    |
               |                                  | 0..*           1..*                | 1..*
+-----------------------------+     +-----------------------------+     +-----------------------------+
|            Admin            |     |            Song             |----♢|            Album            |
+-----------------------------+     +-----------------------------+     |-----------------------------|
| + createUser(String)        |     | - title: string             |     | - titles: String[1..*]      |
| + manageQueue()             |     | - artist: string            |     | - songs: String[1..*]       |
+-----------------------------+     |-----------------------------|     |-----------------------------|
                                    | + getTitle(): string        |     | + getTitles(): String[1..*] |
                                    | + getArtist(): string       |     | + getSong(string): Song     |
                                    | + play()                    |     +-----------------------------+
                                    +-----------------------------+
```
