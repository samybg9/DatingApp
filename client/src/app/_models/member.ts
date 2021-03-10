import { Photo } from "./photo";

export interface Member {
    id: number;
    username: string;
    photoUrl: string;
    knownAs: string;
    age: number;
    createdAt: Date;
    lastActive: Date;
    gender: string;
    introduction: string;
    lookingFor: string;
    interests: string;
    city: string;
    country?: any;
    photos: Photo[];
  }
  
