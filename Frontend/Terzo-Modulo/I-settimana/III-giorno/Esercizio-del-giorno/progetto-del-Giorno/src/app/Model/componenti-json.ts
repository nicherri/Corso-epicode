import { iPost } from "./i-post"

export interface iComponentiJson {
  posts: iPost[]
  total: number
  skip: number
  limit: number
}
