# Challenge: Jukebox Conceptual Model

---

## Goal

Create a conceptual model - Identify objects, responsibilities, and relationships

---

## Exercise

### Noun Phrases

* User
* Library
* Album
* Song
* Queue
* Admin

### Verb Phrases

* Browse library of albums
* Browse songs in album
* Select album
* Select song
* Play selected song
* Add song to queue
* Play song from queue
* Cancel song in queue
* Identify user

```text
     +-------+          +---------+         +---------+
     | Admin |----------|   User  |         | Library |
     +-------+          +---------+         +---------+
         |                  |||            display album
         |                 / | \            select album
         |      gets ID   /  |  \   browses     | 1
         |   ,...........'   |   '..........,   |
moderates|  /                |               \  | contains
         | /                 | selects        \ |
         ||                  |                 || 1..*
      +-------+ contains +------+  contains +-------+
      | Queue |----------| Song |-----------| Album |
      +-------+ 1   0..* +------+ 1..*    1 +-------+
      add song             play           display songs
    get next song                          select song
     remove song
    identify user
```
