# Challenge: Jukebox Class Diagram

---

## Goal

Create UML diagrams based on the conceptual model created from challenge 04

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
                                    | + removeSong(Song)          |     | + getAlbum(String): Album   |
                                    +-----------------------------+     +-----------------------------+



+-----------------------------+     +-----------------------------+     +-----------------------------+
|            Admin            |     |            Song             |     |            Album            |
+-----------------------------+     +-----------------------------+     |-----------------------------|
| - id: String                |     | - title: string             |     | - titles: String[1..*]      |
|-----------------------------|     | - artist: string            |     | - songs: String[1..*]       |
| + getId(): String           |     |-----------------------------|     |-----------------------------|
| + createUser(String)        |     | + getTitle(): string        |     | + getTitles(): String[1..*] |
| + manageQueue()             |     | + getArtist(): string       |     | + getSong(string): Song     |
+-----------------------------+     | + play()                    |     +-----------------------------+
                                    +-----------------------------+
```
