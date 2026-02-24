```mermaid
erDiagram

    PARCEL {
        int Id PK
        string TrackingNumber "Unique"
        int SenderId FK
        int ReceiverId FK
        int StatusId FK
        int TrackingId FK
    }

    SENDER {
        int Id PK
        string Name
        string ContactInfo
    }

    RECEIVER {
        int Id PK
        string Name
        string ContactInfo
    }

    STATUS {
        int Id PK
        string Description
    }

    TRACKING {
        int Id PK
        string TrackingNumber
        datetime CreatedAt
    }

    PARCEL ||--|| SENDER : has
    PARCEL ||--|| RECEIVER : has
    PARCEL ||--|| STATUS : has
    PARCEL ||--|| TRACKING : uses