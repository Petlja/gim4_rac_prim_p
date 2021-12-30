# https://docs.python.org/3/library/hashlib.html
import hashlib
m = hashlib.sha256()
m.update(b"Nobody inspects")
m.update(b" the spammish repetition")
print(m.digest())
print(m.digest_size)
print(m.block_size)

print(hashlib.sha224(b"Nobody inspects the spammish repetition").hexdigest())